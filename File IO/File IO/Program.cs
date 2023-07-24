using System;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            FileExists();
            //ReadFileLines();
            //ReadAllText();
            //FileCopy();
            //FileDelete();
        }
        public static void FileExists()
        {
            string path = @"C:\Users\deepi\source\repos\C-Sharp\BioData.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists " + Path.GetFileName(path));
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        public static void ReadFileLines()
        {
            string path = @"C:\Users\deepi\source\repos\C-Sharp\BioData.txt";
            if (File.Exists(path))
            {
                String[] lines;
                lines = File.ReadAllLines(path);

                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        public static void ReadAllText() 
        {
            string path = @"C:\Users\deepi\source\repos\C-Sharp\BioData.txt";
            if (File.Exists(path))
            {
                String lines;
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        public static void FileCopy()
        {
            string path = @"C:\Users\deepi\source\repos\C-Sharp\BioData.txt";
            if (File.Exists(path))
            {
                String copypath = @"C:\Users\deepi\source\repos\C-Sharp\BioDataNew.txt";

                File.Copy(path, copypath);
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        public static void FileDelete()
        {
            string path = @"C:\Users\deepi\source\repos\C-Sharp\BioData1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
    }
}
