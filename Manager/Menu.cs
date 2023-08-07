using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadedFileDownload.Manager
{
    internal class Menu
    {
        public string path = @"C:\Users\HP\source\repos\MultiThreadedFileDownload\Files";

        public string prev;
        public DirectoryInfo info;
        public FileInfo fileInfo;
        public void Run()
        {
            Console.WriteLine("Papka: Files");
            GetDirectory(path);
            //Print(path);
        }
        public void Print(string path)
        {
            var dir = Directory.GetDirectories(path);
            var file = Directory.GetFiles(path);
            //GetDirectory(path);

            while (true /*File.Exists(path) || Directory.Exists(path)*/)
            {

                Console.WriteLine("Viberite: ");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    GetDirectory(prev);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    prev = Directory.GetParent(path).FullName;
                    if(file.Length!=0) fileInfo = new FileInfo(file[choose-1]);

                    if(  fileInfo!=null ) {
                        new InstallManager().Run(fileInfo.Name);
                        GetDirectory(path);
                    }
                    else GetDirectory(dir[choose - 1]);
                }
            }



        }
        public void GetDirectory(string path)
        {
            prev = Directory.GetParent(path).FullName;

            int count = 1;
            var dir = Directory.GetDirectories(path);
            info = new DirectoryInfo(path);
            Console.WriteLine("--------" + info.Name + "---------");
            foreach (var dirEntry in dir)
            {
                info = new DirectoryInfo(dirEntry);
                Console.WriteLine($"Papka: {count} - {info.Name}");
                count++;
            }
            GetFiles(path, count);


        }
        public void GetFiles(string path, int count)
        {
            var file = Directory.GetFiles(path);
            foreach (var fileEntry in file)
            {
                info = new DirectoryInfo(fileEntry);
                Console.WriteLine($"       {count} - {info.Name}");
                count++;
            }
            Console.WriteLine("0 - Nazad");
            Print(path);


        }
    }
}
