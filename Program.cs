using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchool
{
    internal class Program
    {
        public static void FileFun()
        {
            string path = @"d:\\Project\\Rainbowschool\\students.txt";

            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string tillEnd = sr.ReadToEnd();
                Console.WriteLine(tillEnd);

                sr.Close();
            }
            else
            {
                Console.WriteLine("File Not Found\nPlease Create StudentData.txt file\n");
            }
        }
        static void Main(string[] args)
        {
            FileFun();

        }
    }

}
    


