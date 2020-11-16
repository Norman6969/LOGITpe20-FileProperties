using System;
using System.Collections.Generic;
using System.IO;

namespace FileAndProperties
{
    class Program
    {
        private static string line;

        static void Main(string[] args)
        {
            //to get the file names only
            string rootPath = @"C:\Users\opilane\Sampfiles";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //get file object
                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {fileDirectory}; Size: {fileSize}");
                string line = ($"File name: {fileName}; location: {fileDirectory}; Size: {fileSize}");
                lines.Add(line);

            }

            string fileDataPath = @"C:\Users\opilane\Sampfiles\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
