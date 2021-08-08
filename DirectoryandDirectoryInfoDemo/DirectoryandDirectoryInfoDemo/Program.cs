using System;
using System.IO;

namespace DirectoryandDirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//Directory and DirectoryInfo\\\\");

            //Directory provides static methods, DirectoryInfo instance.

            Directory.CreateDirectory(@"c:\");
            //Get files in a specific directory. This looks for all files (search pattern *.* and all sub directories.
            var list = Directory.GetFiles(@"D:\", "*.*", SearchOption.AllDirectories);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            var directories = Directory.GetDirectories(@"C:\", "*.*", SearchOption.AllDirectories);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Directory.Exists("...");

            //Directory Info
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


        }
    }
}
