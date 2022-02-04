using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g1, g2, g3;

            string fileName = @"C:\Users\roohana.siddiqui\source\repos\PS1\PS1\abc.txt";

            string[] lines = File.ReadAllLines(fileName);
            Console.WriteLine("Enter 3 numbers");
            for (int i = 0; i < lines.Length; i++)
            {
                string var = lines[i];
                string[] var1 = var.Split(' ');
                g1 = int.Parse(var1[0]);
                g2=int.Parse(var1[1]);
                g3=int.Parse(var1[2]);
                Eygypt e = new Eygypt(g1, g2, g3);
                String answer = e.perfectsquare();
                Console.WriteLine(answer);
            }
                
                
            
           
         
            
        }
    }
}
