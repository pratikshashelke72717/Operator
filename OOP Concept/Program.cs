using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Arithmetic Operator
			int a = 4;
			int b = 5;
			Console.WriteLine("The value of a+b:"+(a+b));
			Console.WriteLine("The value of a-b:" + (a - b));
			Console.WriteLine("The value of a*b:" + (a * b));
			Console.WriteLine("The value of a/b:" + (a /b));



			//Assignment Operator
			Console.WriteLine("Assignment Operator");		
			int c = 5;
			int d = c;
			d += 4;
			//d -= 4;
			//d *= 4;
			//d /= 4;
			Console.WriteLine(d);



			//Logical Operator
			Console.WriteLine("Logical Oprator");
			Console.WriteLine(true && false);
			Console.WriteLine(true && true);

			Console.WriteLine(false && false);

			Console.WriteLine(true || false);
			Console.WriteLine(true || true);

			Console.WriteLine(false || false);





			//Comparision Operator
			Console.WriteLine("Comparision Operator");
            int x = 5;
			int y = 3;
			Console.WriteLine(x > y);
			Console.WriteLine(x < y);
			Console.WriteLine(x >= y);
			Console.WriteLine(x >=y);
			Console.WriteLine(x != y);
			Console.ReadLine();



		}
	}
}
