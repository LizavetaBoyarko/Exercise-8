using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "File.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(0, 10));
            }
            sw.Close();

            int[] arraynumbers = new int[10];

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < arraynumbers.Length; i++)
                {
                    arraynumbers[i] = Convert.ToInt32(sr.ReadLine());
                }
            }
            int Sum = 0;
            for (int i = 0; i < arraynumbers.Length; i++)
            {
                Sum += arraynumbers[i];
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
