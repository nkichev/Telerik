namespace DirectoryStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DirectoryStructureDemo
    {
        public const string SEARCH_PATTERN = "*.*";
        public const string ROOT_DIRECTORY = "C:\\Windows";
        private static StringBuilder errorLog = new StringBuilder();

        public static void Main()
        {
            Folder root = new Folder(ROOT_DIRECTORY);
            GenerateFolders(root);

            Console.WriteLine("Folder: " + root.Name);
            Console.WriteLine("Size in bytes: " + root.GetSize());
        }

        public static void GenerateFolders(Folder folder)
        {
            try
            {
                var dirs = Directory.GetDirectories(folder.Name);
                var fileNames = Directory.GetFiles(folder.Name, SEARCH_PATTERN);
                var files = GenerateFiles(fileNames);

                folder.Files.AddRange(files);

                foreach (var dir in dirs)
                {
                    Folder currentFolder = new Folder(dir);
                    folder.ChildFolders.Add(currentFolder);
                    GenerateFolders(currentFolder);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                errorLog.AppendLine(ex.Message);
                return;
            }
        }

        private static List<File> GenerateFiles(string[] filesNames)
        {
            List<File> files = new List<File>();

            for (int i = 0; i < filesNames.Length; i++)
            {
                FileInfo newFileInfo = new FileInfo(filesNames[i]);
                long fileSize = newFileInfo.Length;
                files.Add(new File(filesNames[i], fileSize));
            }

            return files;
        }
    }
}