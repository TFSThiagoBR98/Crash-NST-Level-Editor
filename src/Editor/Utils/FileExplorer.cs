using System.IO;
using System.Linq;
using System.Collections.Generic;
using NativeFileDialogSharp;

namespace NST
{
    /// <summary>
    /// Utility class for opening and saving files using cross-platform NativeFileDialogSharp
    /// </summary>
    public static class FileExplorer
    {
        public static string EXT_ALL = "All files (*.*)|*.*";
        public static string EXT_ALCHEMY = "Alchemy files (*.pak,*.igz)|*.pak;*.igz;|" + EXT_ALL;
        public static string EXT_ARCHIVES = "PAK archives (*.pak)|*.pak|" + EXT_ALL;
        public static string EXT_IMAGES = "Image Files|*.png;*.apng;*.jpg;*.jpeg;*.jfif;*.gif;*.bm;*.bmp;*.dip;*.ppm;*.pbm;*.pgm;*.tga;*.vda;*.icb;*.vst;*.tiff;*.tif;*.webp;*.qoi";
        public static string EXT_AUDIO = "Audio Files (*.mp3,*.ogg,*.wav)|*.mp3;*.ogg;*.wav|" + EXT_ALL;
        public static string EXT_EXECUTABLE = "Executable Files (*.exe)|*.exe|" + EXT_ALL;

        private static string? ConvertFilter(string winFormsFilter)
        {
            var parts = winFormsFilter.Split('|');
            var nfdFilters = new List<string>();
            for (int i = 1; i < parts.Length; i += 2)
            {
                var pattern = parts[i];
                if (pattern == "*.*") continue;
                
                var exts = pattern.Split(';')
                                  .Select(p => p.Trim().Replace("*.", "").Replace(".", ""))
                                  .Where(e => !string.IsNullOrEmpty(e) && e != "*");
                if (exts.Any())
                {
                    nfdFilters.Add(string.Join(",", exts));
                }
            }
            string result = string.Join(";", nfdFilters);
            return string.IsNullOrEmpty(result) ? null : result;
        }

        public static List<string> OpenFiles(string extensions, bool multiSelect, string? initialDirectory = null)
        {
            string defaultPath = initialDirectory ?? LocalStorage.Get("last_open_path", LocalStorage.ArchivePath) ?? string.Empty;
            string? filter = ConvertFilter(extensions);

            if (multiSelect)
            {
                var result = Dialog.FileOpenMultiple(filter, defaultPath);
                if (result.IsOk)
                {
                    var paths = result.Paths.ToList();
                    if (paths.Count > 0 && initialDirectory == null)
                    {
                        string? path = Path.GetDirectoryName(paths[0]);
                        if (path != null) LocalStorage.Set("last_open_path", path);
                    }
                    return paths;
                }
            }
            else
            {
                var result = Dialog.FileOpen(filter, defaultPath);
                if (result.IsOk)
                {
                    if (initialDirectory == null)
                    {
                        string? path = Path.GetDirectoryName(result.Path);
                        if (path != null) LocalStorage.Set("last_open_path", path);
                    }
                    return [result.Path];
                }
            }

            return [];
        }

        public static string? SaveFile(string extensions, string defaultName, string? initialDirectory = null)
        {
            string defaultPath = initialDirectory ?? LocalStorage.Get("last_save_path", "") ?? string.Empty;
            
            if (!string.IsNullOrEmpty(defaultName))
            {
                defaultPath = Path.Combine(defaultPath, SanitizeFileName(defaultName));
            }

            string? filter = ConvertFilter(extensions);

            var result = Dialog.FileSave(filter, defaultPath);

            if (result.IsOk)
            {
                if (initialDirectory == null)
                {
                    string? path = Path.GetDirectoryName(result.Path);
                    if (path != null) LocalStorage.Set("last_save_path", path);
                }
                return result.Path;
            }

            return null;
        }

        private static string SanitizeFileName(string fileName)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars());

            for (int i = 0; i < fileName.Length; i++)
            {
                char currentChar = fileName[i];

                if (invalidChars.Contains(currentChar))
                {
                    fileName = fileName.Replace(currentChar, '_');
                }
            }

            return fileName;
        }
    }
}