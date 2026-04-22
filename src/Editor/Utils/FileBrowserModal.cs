using ImGuiNET;
using System.Numerics;

namespace NST
{
    public class FileBrowserModal : IModalBase
    {
        private enum BrowserMode { Open, OpenMultiple, Save }
        private record FileEntry(string Name, string FullPath, bool IsDirectory, long Size);

        private const string PopupId = "##NST_FileBrowser";
        private const float BookmarkWidth = 155f;
        private static readonly Vector2 WindowSize = new(790, 530);

        private BrowserMode _mode;
        private bool _isOpen = false;
        private bool _requestOpen = false;

        private string _currentDir = "";
        private List<FileEntry> _entries = [];
        private string _fileNameInput = "";
        private int _selectedFilter = 0;
        private int _prevFilter = 0;
        private string[] _filterDisplayNames = ["All Files"];
        private string[][] _filterExtensions = [[]];

        private readonly HashSet<string> _selectedFiles = [];
        private bool _focusFileInput = false;
        private bool _scrollToTop = false;

        private readonly Stack<string> _historyBack = new();
        private readonly Stack<string> _historyFwd = new();

        private Action<List<string>>? _openCallback;
        private Action<string?>? _saveCallback;

        private static List<(string Name, string Path)>? _bookmarksCache;

        public bool IsOpen() => _isOpen;

        public void ShowOpen(string filter, bool multiSelect, Action<List<string>> callback, string? initialDir)
        {
            _mode = multiSelect ? BrowserMode.OpenMultiple : BrowserMode.Open;
            _openCallback = callback;
            _saveCallback = null;
            ParseFilter(filter);
            string startDir = initialDir ?? LocalStorage.Get("last_open_path", GetHomeDir()) ?? GetHomeDir();
            NavigateTo(EnsureValidDir(startDir), recordHistory: false);
            _fileNameInput = "";
            _selectedFiles.Clear();
            _focusFileInput = false;
            _historyBack.Clear();
            _historyFwd.Clear();
            _isOpen = true;
            _requestOpen = true;
        }

        public void ShowSave(string filter, string defaultName, Action<string?> callback, string? initialDir)
        {
            _mode = BrowserMode.Save;
            _saveCallback = callback;
            _openCallback = null;
            ParseFilter(filter);
            string startDir = initialDir ?? LocalStorage.Get("last_save_path", GetHomeDir()) ?? GetHomeDir();
            NavigateTo(EnsureValidDir(startDir), recordHistory: false);
            _fileNameInput = defaultName;
            _selectedFiles.Clear();
            _focusFileInput = true;
            _historyBack.Clear();
            _historyFwd.Clear();
            _isOpen = true;
            _requestOpen = true;
        }

        public bool Render()
        {
            if (_requestOpen)
            {
                ImGui.OpenPopup(PopupId);
                _requestOpen = false;
            }

            ImGui.SetNextWindowSize(WindowSize, ImGuiCond.Always);
            bool modalOpen = ImGui.BeginPopupModal(PopupId, ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoSavedSettings | ImGuiWindowFlags.NoTitleBar);

            if (!modalOpen)
            {
                _isOpen = false;
                return false;
            }

            string title = _mode switch {
                BrowserMode.OpenMultiple => "Open Files",
                BrowserMode.Save => "Save File",
                _ => "Open File"
            };
            ImGui.SeparatorText(title);

            RenderNavBar();

            // Detect filter change (combo is in footer but entries must reflect it)
            if (_selectedFilter != _prevFilter)
            {
                _prevFilter = _selectedFilter;
                RefreshEntries();
            }

            float footerHeight = 54f;
            float mainHeight = ImGui.GetContentRegionAvail().Y - footerHeight;

            if (ImGui.BeginChild("##fb_bookmarks", new Vector2(BookmarkWidth, mainHeight), ImGuiChildFlags.FrameStyle))
            {
                RenderBookmarks();
            }
            ImGui.EndChild();

            ImGui.SameLine();

            if (ImGui.BeginChild("##fb_files", new Vector2(-1, mainHeight), ImGuiChildFlags.FrameStyle))
            {
                if (_scrollToTop)
                {
                    ImGui.SetScrollHereY(0);
                    _scrollToTop = false;
                }
                RenderFileList();
            }
            ImGui.EndChild();

            RenderFooter();

            if (ImGui.IsKeyPressed(ImGuiKey.Escape))
                Cancel();

            ImGui.EndPopup();
            return true;
        }

        private void RenderNavBar()
        {
            bool canBack = _historyBack.Count > 0;
            bool canFwd = _historyFwd.Count > 0;
            bool canUp = Path.GetDirectoryName(_currentDir) != null;

            if (!canBack) ImGui.BeginDisabled();
            if (ImGui.SmallButton(" < ")) NavigateBack();
            if (!canBack) ImGui.EndDisabled();
            ImGui.SameLine();

            if (!canFwd) ImGui.BeginDisabled();
            if (ImGui.SmallButton(" > ")) NavigateForward();
            if (!canFwd) ImGui.EndDisabled();
            ImGui.SameLine();

            if (!canUp) ImGui.BeginDisabled();
            if (ImGui.SmallButton(" ^ ")) NavigateUp();
            if (!canUp) ImGui.EndDisabled();
            ImGui.SameLine();

            ImGui.SetNextItemWidth(-1);
            string dirInput = _currentDir;
            if (ImGui.InputText("##fb_path", ref dirInput, 512, ImGuiInputTextFlags.EnterReturnsTrue))
            {
                if (Directory.Exists(dirInput))
                    NavigateTo(dirInput);
            }
        }

        private void RenderBookmarks()
        {
            _bookmarksCache ??= BuildBookmarks();

            foreach (var (name, path) in _bookmarksCache)
            {
                if (string.IsNullOrEmpty(name))
                {
                    ImGui.Separator();
                    continue;
                }
                if (ImGui.Selectable(name, _currentDir == path))
                    NavigateTo(path);
                if (ImGui.IsItemHovered() && path != name)
                    ImGui.SetTooltip(path);
            }
        }

        private void RenderFileList()
        {
            if (!ImGui.BeginTable("##fb_table", 2,
                ImGuiTableFlags.BordersInnerV | ImGuiTableFlags.RowBg | ImGuiTableFlags.ScrollY | ImGuiTableFlags.SizingStretchProp,
                new Vector2(-1, -1)))
                return;

            ImGui.TableSetupScrollFreeze(0, 1);
            ImGui.TableSetupColumn("Name", ImGuiTableColumnFlags.WidthStretch);
            ImGui.TableSetupColumn("Size", ImGuiTableColumnFlags.WidthFixed, 75);
            ImGui.TableHeadersRow();

            string? pendingNavigate = null;

            foreach (var entry in _entries)
            {
                ImGui.TableNextRow();
                ImGui.TableSetColumnIndex(0);

                bool selected = _selectedFiles.Contains(entry.FullPath);
                string displayName = entry.IsDirectory ? entry.Name + "/" : entry.Name;

                bool clicked = ImGui.Selectable(
                    displayName + "##" + entry.FullPath, selected,
                    ImGuiSelectableFlags.SpanAllColumns | ImGuiSelectableFlags.AllowDoubleClick,
                    new Vector2(0, 0));

                if (clicked)
                {
                    bool isDoubleClick = ImGui.IsMouseDoubleClicked(ImGuiMouseButton.Left);
                    if (entry.IsDirectory && isDoubleClick)
                        pendingNavigate = entry.FullPath;
                    else
                        HandleEntryClick(entry);
                }

                ImGui.TableSetColumnIndex(1);
                if (!entry.IsDirectory)
                    ImGui.TextDisabled(FormatSize(entry.Size));
            }

            ImGui.EndTable();

            if (pendingNavigate != null)
                NavigateTo(pendingNavigate);
        }

        private void RenderFooter()
        {
            ImGuiUtils.VerticalSpacing(4);

            float spacing = ImGui.GetStyle().ItemSpacing.X;
            float buttonWidth = 75f;
            float filterWidth = 200f;
            float fileNameWidth = ImGui.GetContentRegionAvail().X - filterWidth - buttonWidth * 2 - spacing * 4;

            if (_focusFileInput)
            {
                ImGui.SetKeyboardFocusHere();
                _focusFileInput = false;
            }

            ImGui.SetNextItemWidth(fileNameWidth);

            bool confirmed = false;
            if (_mode == BrowserMode.Save)
            {
                confirmed = ImGui.InputText("##fb_filename", ref _fileNameInput, 512, ImGuiInputTextFlags.EnterReturnsTrue);
            }
            else
            {
                string display = string.Join("; ", _selectedFiles.Select(Path.GetFileName)!);
                ImGui.InputText("##fb_filename_ro", ref display, 512, ImGuiInputTextFlags.ReadOnly);
            }

            ImGui.SameLine();
            ImGui.SetNextItemWidth(filterWidth);
            ImGui.Combo("##fb_filter", ref _selectedFilter, _filterDisplayNames, _filterDisplayNames.Length);

            ImGui.SameLine();
            if (ImGui.Button("Cancel", new Vector2(buttonWidth, 0)))
                Cancel();

            ImGui.SameLine();

            bool canConfirm = _mode == BrowserMode.Save
                ? !string.IsNullOrWhiteSpace(_fileNameInput)
                : _selectedFiles.Count > 0;

            if (!canConfirm) ImGui.BeginDisabled();
            string confirmLabel = _mode == BrowserMode.Save ? "Save" : "Open";
            if (ImGui.Button(confirmLabel, new Vector2(buttonWidth, 0)) || confirmed)
                Confirm();
            if (!canConfirm) ImGui.EndDisabled();
        }

        private void HandleEntryClick(FileEntry entry)
        {
            bool isDoubleClick = ImGui.IsMouseDoubleClicked(ImGuiMouseButton.Left);
            bool isCtrl = ImGui.GetIO().KeyCtrl;

            if (entry.IsDirectory)
            {
                if (isDoubleClick)
                    NavigateTo(entry.FullPath);
            }
            else
            {
                if (_mode == BrowserMode.OpenMultiple && isCtrl)
                {
                    if (!_selectedFiles.Remove(entry.FullPath))
                        _selectedFiles.Add(entry.FullPath);
                }
                else
                {
                    _selectedFiles.Clear();
                    _selectedFiles.Add(entry.FullPath);
                    _fileNameInput = entry.Name;
                }

                if (isDoubleClick)
                    Confirm();
            }
        }

        private void Confirm()
        {
            if (_mode == BrowserMode.Save)
            {
                if (string.IsNullOrWhiteSpace(_fileNameInput)) return;

                string filePath = Path.Combine(_currentDir, _fileNameInput);

                if (_filterExtensions.Length > _selectedFilter && _filterExtensions[_selectedFilter].Length > 0)
                {
                    string requiredExt = _filterExtensions[_selectedFilter][0];
                    if (!Path.GetExtension(filePath).Equals("." + requiredExt, StringComparison.OrdinalIgnoreCase))
                        filePath += "." + requiredExt;
                }

                _isOpen = false;
                ImGui.CloseCurrentPopup();
                LocalStorage.Set("last_save_path", _currentDir);
                _saveCallback?.Invoke(filePath);
            }
            else
            {
                if (_selectedFiles.Count == 0) return;

                var paths = _selectedFiles.ToList();
                _isOpen = false;
                ImGui.CloseCurrentPopup();
                LocalStorage.Set("last_open_path", _currentDir);
                _openCallback?.Invoke(paths);
            }
        }

        private void Cancel()
        {
            _isOpen = false;
            ImGui.CloseCurrentPopup();
            _openCallback?.Invoke([]);
            _saveCallback?.Invoke(null);
        }

        private void NavigateTo(string dir, bool recordHistory = true)
        {
            if (!Directory.Exists(dir)) return;

            if (recordHistory && _currentDir != dir)
            {
                _historyBack.Push(_currentDir);
                _historyFwd.Clear();
            }

            _currentDir = dir;
            _selectedFiles.Clear();
            _fileNameInput = _mode == BrowserMode.Save ? _fileNameInput : "";
            _scrollToTop = true;
            RefreshEntries();
        }

        private void NavigateBack()
        {
            if (_historyBack.Count == 0) return;
            _historyFwd.Push(_currentDir);
            NavigateTo(_historyBack.Pop(), recordHistory: false);
        }

        private void NavigateForward()
        {
            if (_historyFwd.Count == 0) return;
            _historyBack.Push(_currentDir);
            NavigateTo(_historyFwd.Pop(), recordHistory: false);
        }

        private void NavigateUp()
        {
            string? parent = Path.GetDirectoryName(_currentDir);
            if (parent != null) NavigateTo(parent);
        }

        private void RefreshEntries()
        {
            _entries.Clear();

            try
            {
                foreach (string dir in Directory.GetDirectories(_currentDir).OrderBy(Path.GetFileName))
                {
                    string name = Path.GetFileName(dir) ?? dir;
                    _entries.Add(new FileEntry(name, dir, true, 0));
                }

                string[] allowedExts = _filterExtensions.Length > _selectedFilter
                    ? _filterExtensions[_selectedFilter]
                    : [];

                foreach (string file in Directory.GetFiles(_currentDir).OrderBy(Path.GetFileName))
                {
                    string ext = Path.GetExtension(file).TrimStart('.').ToLower();
                    if (allowedExts.Length == 0 || allowedExts.Contains(ext))
                    {
                        string name = Path.GetFileName(file);
                        long size = new FileInfo(file).Length;
                        _entries.Add(new FileEntry(name, file, false, size));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[FileBrowser] Error reading {_currentDir}: {e.Message}");
            }
        }

        private void ParseFilter(string winFormsFilter)
        {
            var parts = winFormsFilter.Split('|');
            var displayNames = new List<string>();
            var extensions = new List<string[]>();

            for (int i = 0; i + 1 < parts.Length; i += 2)
            {
                string displayName = parts[i];
                string pattern = parts[i + 1];
                var exts = pattern.Split(';')
                    .Select(p => p.Trim().TrimStart('*').TrimStart('.').ToLower())
                    .Where(e => !string.IsNullOrEmpty(e) && e != "*")
                    .ToArray();
                displayNames.Add(displayName);
                extensions.Add(exts);
            }

            if (displayNames.Count == 0)
            {
                displayNames.Add("All Files");
                extensions.Add([]);
            }

            _filterDisplayNames = [.. displayNames];
            _filterExtensions = [.. extensions];
            _selectedFilter = 0;
            _prevFilter = 0;
        }

        private static string GetHomeDir()
            => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        private static string EnsureValidDir(string path)
        {
            if (File.Exists(path)) path = Path.GetDirectoryName(path) ?? path;
            if (!Directory.Exists(path)) path = GetHomeDir();
            return path;
        }

        private static string FormatSize(long bytes)
        {
            if (bytes < 1024) return $"{bytes} B";
            if (bytes < 1024 * 1024) return $"{bytes / 1024.0:F1} KB";
            if (bytes < 1024L * 1024 * 1024) return $"{bytes / (1024.0 * 1024):F1} MB";
            return $"{bytes / (1024.0 * 1024 * 1024):F1} GB";
        }

        private static List<(string Name, string Path)> BuildBookmarks()
        {
            var list = new List<(string, string)>();
            string home = GetHomeDir();

            AddIfExists(list, "Home", home);
            AddIfExists(list, "Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            AddIfExists(list, "Documents", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            AddIfExists(list, "Downloads", Path.Combine(home, "Downloads"));

            list.Add(("", "")); // separator

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    list.Add((drive.Name.TrimEnd('\\', '/'), drive.RootDirectory.FullName));
            }

            return list;
        }

        private static void AddIfExists(List<(string, string)> list, string name, string path)
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                list.Add((name, path));
        }
    }
}
