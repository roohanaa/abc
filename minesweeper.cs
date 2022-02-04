using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string[] lines = File.ReadAllLines(@"C:\Users\roohana.siddiqui\source\repos\RMS\RMS\minesweeper.txt");

            string[] Minesarray = new string[int.Parse(lines[0])];
            string[] Currentarray = new string[int.Parse(lines[0])];
            string[] Outputarray = new string[int.Parse(lines[0])];

            string stringg = "";
            int count = 0;
            int value;


            for (int i = 0; i < int.Parse(lines[0]); i++)
            {
                Minesarray[i] = lines[i + 1];
                Currentarray[i] = lines[int.Parse(lines[0]) + i + 1];
            }

            for (int i = 0; i < int.Parse(lines[0]); i++)
            {
                for (int j = 0; j < int.Parse(lines[0]); j++)
                {
                    if (Currentarray[i][j] == 'x' && Minesarray[i][j] == '*')
                    {
                        Array.Copy(Minesarray, 0, Outputarray, 0, int.Parse(lines[0]));
                        count++;

                        break;
                    }
                    else if (Currentarray[i][j] == '.')//jaisy hi X k bad . ajaye
                    {
                        stringg = "";
                        stringg = Outputarray[i] + ".";
                        Outputarray[i] = stringg;
                    }
                    else
                    {
                        value = 0;

                        //here top-bottom

                        if (i + 1 < int.Parse(lines[0]) && Minesarray[i + 1][j] == '*') { value++; }//down
                        

                        if (i - 1 >= 0 && Minesarray[i - 1][j] == '*') //up
                        {
                            value++;
                        }

                        if (j + 1 < int.Parse(lines[0]) && Minesarray[i][j + 1] == '*')//right
                        {
                            value++;
                        }

                        if (j - 1 >= 0 && Minesarray[i][j - 1] == '*')//left
                        {
                            value++;
                        }

                        //here Daigonally 
                        if (i + 1 < int.Parse(lines[0]) && j + 1 < int.Parse(lines[0]) && Minesarray[i + 1][j + 1] == '*')//rightbottm
                        {
                            value++;
                        }

                        if (i + 1 < int.Parse(lines[0]) && j - 1 >= 0 && Minesarray[i + 1][j - 1] == '*')//lft bottm
                        {
                            value++;
                        }

                        if (i - 1 >= 0 && j + 1 < int.Parse(lines[0]) && Minesarray[i - 1][j + 1] == '*')//right top
                        {
                            value++;
                        }

                        if (i - 1 >= 0 && j - 1 >= 0 && Minesarray[i - 1][j - 1] == '*')//lft top
                        {
                            value++;
                        }

                        stringg = "";
                        stringg = Outputarray[i] + value.ToString();
                        Outputarray[i] = stringg;
                    }
                }

                if (count == 1)
                {
                    break;
                }
            }

            foreach (string output in Outputarray)
            {
                Console.WriteLine(output);
            }
        }
    }
}
