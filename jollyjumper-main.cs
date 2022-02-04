using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jollyjumper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5,1,4,2,-1,6 };
            int n = a.Length;
            jollyjumper jj = new jollyjumper();
           string s= jj.isJolly(a,n);
            Console.WriteLine(s);
          
        }
    }
}
