using System;

namespace Methods
{
	class MainClass
	{

		static void Sum(int x, int y){
			Console.WriteLine (x+y);
		}

		static void SubtractFromTen(int z, int w = 10){
			Console.WriteLine (w-z);
		}

		public static void Main (string[] args)
		{
			Sum (10, 15);
			SubtractFromTen (10);
		}
	}
}
