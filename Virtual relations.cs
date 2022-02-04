using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualfriendship
{
    public class Program
    {
        static List<String> members=new List<string>();
        static int count;
        public void CreateMututalF(string[] frMem)
        {

            for (int i = 0; i < frMem.Length-1; i++)
            {
                if (members.Contains(frMem[i]))
                {
                    count++;
                    members.Add(frMem[i + 1]);
                    Console.WriteLine(count);

                }
                else
                {
                    count = 1;
                    members.Add(frMem[i]);
                    members.Add(frMem[i + 1]);
                    count++;
                }
            }



        }
        //static List<String> dmembers = new List<string>();
        //int dcount;
        //public void createFriend(int nof, string[] mem)
        //{
        //    for (int i = 0; i < mem.Length - 1; i++)
        //    {
        //        if (members.Count == 0)
        //        {
        //            dmembers.Add(mem[i]);
        //            dcount++;
        //            dmembers.Add(mem[i + 1]);
        //            dcount++;
        //        }
        //        if (dmembers.Contains(mem[i]))
        //        {
        //            dmembers.Add(mem[i + 1]);
        //            dcount++;
        //            Console.WriteLine(count);

        //        }


        //    }

        //}
       
        static void Main(string[] args)
        {
            ConsoleKeyInfo ch;
            Console.WriteLine("enter testcase");
            int test = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no of friends");
            int NF = int.Parse((Console.ReadLine()));
            while (true)
            {
                
                Console.WriteLine("Add virtualfriend with gap");
                string m = Console.ReadLine();
                string[] frMem = m.Split(' ');
                //VR vr = new VR();
                //vr.createFriend(NF,frMem);
                Program p = new Program();
                p.CreateMututalF(frMem);

                Console.WriteLine("Enter Escape to exit ");
                ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.Escape)
                {
                    break;
                }
               
            }   
           
            

        }
       
    }
}
