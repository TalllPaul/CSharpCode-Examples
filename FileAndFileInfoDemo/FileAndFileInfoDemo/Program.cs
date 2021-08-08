using System;
using System.IO;

namespace FileAndFileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//FILE AND FILEINFO CLASSES\\\\");

            //File provides static methods, FileInfo provides instance methids.

            var ruta = @"c:\somefile.jpg";
            //Copies the first file to the destination, true means that if it exists it can be overwritten.
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //Delete
            File.Delete(ruta);
            //Check if exists
            if(File.Exists(ruta))
            {
                //Do something
            }
            //Returns a string of text
            File.ReadAllText(ruta);
            //Returns byte array
            File.ReadAllBytes(ruta);

            //FILEINFO
            var fileInfo = new FileInfo(ruta);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //Do something
            }

            //fileinfo doesn't have a readalltext method like file.
            
            
        }
    }
}
