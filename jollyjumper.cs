using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jollyjumper
{
    internal class jollyjumper
    {
       
		public String isJolly(int[] array, int number)
		{
			
		
			int[] decendarray=new int[number];
			
			for (int i = 0; i < number - 1; i++)
			{
				
				int d = Math.Abs(array[i] - array[i + 1]);

				decendarray[i] = d;
				
			}
			for (int i = 0; i < decendarray.Length - 1; i++)
			{
				if ((decendarray[i] < decendarray[i + 1]))
				{
					return "not jolly";
				}
			}
			return "jolly";
		}

	
		
	

	
	}
}
