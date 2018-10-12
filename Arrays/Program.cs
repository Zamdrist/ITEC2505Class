using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			var myStringArray = new string[1];
	        if (myStringArray[0] == null)
	        {
		        Console.WriteLine("I am an empty string");
	        }
			Console.WriteLine(myStringArray[0]);
	        Console.ReadLine();

	        var titles = new[] {new[] {"When"}, new[] {"Where"}};
	        var i = 0;
	        foreach (var title in titles)
	        {
		        Console.WriteLine(title[i][1]);
		        i++;
	        }

	        Console.ReadLine();
        }
    }
}
