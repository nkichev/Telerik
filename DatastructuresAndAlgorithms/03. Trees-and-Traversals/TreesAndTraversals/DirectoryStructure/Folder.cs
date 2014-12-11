namespace DirectoryStructure
{
    using System;
    using System.Collections.Generic;

    public class Folder
    {
        public Folder(string name) 
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; private set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public long GetSize()
        {
            long sum = 0;

            foreach (var file in this.Files)
            {
                sum += file.Size;
            }

            foreach (var childFolder in this.ChildFolders)
            {
                sum += childFolder.GetSize();
            }

            return sum;
        }
    }
}