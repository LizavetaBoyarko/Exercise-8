using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Elizaveta/Desktop/Автоматизация BIM";
            Console.WriteLine("Содержимое основного каталога:");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            foreach (string s in dirs)
            {
                string[] subdirs = Directory.GetDirectories(s);
                Console.WriteLine();
                Console.WriteLine($"Содержимое подкаталога: {subdirs}");
                foreach (string a in subdirs)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadKey();


        }
    }
}
