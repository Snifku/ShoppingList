using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePaths();
        }
            public static void WriteFilePaths()
        {
            string filePath = @"C:\Users\opilanesamples\files.txt";
            string directoryPath = @"C:\Users\opilanesamples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            //save to file
            File.WriteAllLines(filePath, files);
            File.WriteAllLines(fileTxt, allFiles);
            Console.WriteLine("");
        }
        
    }
}
