using System;
using System.Linq;
using System.Collections.Generic;

namespace Vikkie_Tutorial
{	
	public class Programs
	{
		public double Add(double a, double b){
			return a+b;
		}
		public double Sub(double a, double b){
			return a-b;
		}
		public double Div(double a, double b){
			return a/b;
		}
		public double Mul(double a, double b){
			return a*b;
		}
		public static void Main(string[] args)
		{
			//Arrays
			/*int[] arr = new int[] {1,2,3,4,5};
			//foreach(int k in arr)
			{
				
				//Console.WriteLine(k);
			}
			Console.WriteLine(arr.Max()+ ""+ arr.Min() );*/
			while(true){
				Programs calc = new Programs();
				char op;
				double a,b,c;
				Console.Write("Enter First Number: ");
				a = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter Operator: ");
				char.TryParse(Console.ReadLine(), out op);
				Console.Write("Enter Second Number: ");
				b = Convert.ToInt32(Console.ReadLine());
				if(op=='+'){
					Console.WriteLine(calc.Add(a,b));
				}
				if(op=='-'){
					Console.WriteLine(calc.Sub(a,b));
				}
				if(op=='*'){
					Console.WriteLine(calc.Mul(a,b));
				}
				if(op=='/'){
					Console.WriteLine(calc.Div(a,b));
				}
			Console.Write("Press any key to stop . . . ");
			Console.ReadKey(true);			
		}
	}
}
	
}