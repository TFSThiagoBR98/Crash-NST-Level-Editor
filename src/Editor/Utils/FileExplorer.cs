using System.IO;

namespace NST
{
    /// <summary>
    /// Utility class for opening and saving files using the ImGui-based file browser
    /// </summary>
    public static class FileExplorer
    {
        public static string EXT_ALL = "All files (*.*)|*.*";
        public static string EXT_ALCHEMY = "Alchemy files (*.pak,*.igz)|*.pak;*.igz;|" + EXT_ALL;
        public static string EXT_ARCHIVES = "PAK archives (*.pak)|*.pak|" + EXT_ALL;
        public static string EXT_IMAGES = "Image Files|*.png;*.apng;*.jpg;*.jpeg;*.jfif;*.gif;*.bm;*.bmp;*.dip;*.ppm;*.pbm;*.pgm;*.tga;*.vda;*.icb;*.vst;*.tiff;*.tif;*.webp;*.qoi";
        public static string EXT_AUDIO = "Audio Files (*.mp3,*.ogg,*.wav)|*.mp3;*.ogg;*.wav|" + EXT_ALL;
        public static string EXT_EXECUTABLE = "Executable Files (*.exe)|*.exe|" + EXT_ALL;

        public static void OpenFiles(string extensions, bool multiSelect, Action<List<string>> onComplete, string? initialDirectory = null)
        {
            string? initialDir = initialDirectory ?? LocalStorage.Get("last_open_path", LocalStorage.ArchivePath);

            ModalRenderer.ShowOpenDialog(extensions, multiSelect, paths =>
            {
                if (paths.Count > 0 && initialDirectory == null)
                {
                    string? dir = Path.GetDirectoryName(paths[0]);
                    if (dir != null) LocalStorage.Set("last_open_path", dir);
                }
                onComplete(paths);
            }, initialDir);
        }

        public static void SaveFile(string extensions, string defaultName, Action<string?> onComplete, string? initialDirectory = null)
        {
            string defaultPath = initialDirectory ?? LocalStorage.Get("last_save_path", "") ?? string.Empty;

            if (!string.IsNullOrEmpty(defaultName))
                defaultPath = Path.Combine(defaultPath, SanitizeFileName(defaultName));

            ModalRenderer.ShowSaveDialog(extensions, Path.GetFileName(defaultPath), path =>
            {
                if (path != null && initialDirectory == null)
                {
                    string? dir = Path.GetDirectoryName(path);
                    if (dir != null) LocalStorage.Set("last_save_path", dir);
                }
                onComplete(path);
            }, Path.GetDirectoryName(defaultPath));
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
