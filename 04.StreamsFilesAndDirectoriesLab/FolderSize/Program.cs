using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("c:/TestFolder");
            double totalSize = 0;

            foreach (var filename in fileNames)
            {
                FileInfo info = new FileInfo(filename);
                totalSize += info.Length;
            }

            totalSize = totalSize / 1024 / 1024;

            File.WriteAllText("оutput.txt", totalSize.ToString());
        }
    }
}
