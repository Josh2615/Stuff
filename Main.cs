using System;

namespace Practice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Enter your name here: ");
			string name = Console.ReadLine();
			
			Console.WriteLine("So your name is {0} and your age is: ", name);
			int age = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Got it! You're {0} and you've been living for {1} years! It's an honor to meet you.", name, age);
			
			Console.ReadLine();
			
			Console.WriteLine("Now it's time to evaluate your input:");
			
			Console.ReadLine();
			
			if (age<=10){
				Console.WriteLine("Too young, buddy. Sorry.");
			} else if (age>10 && age<=30){
				Console.WriteLine("You're in the perfect age range to play my game! Good for you.");
			} else {
				Console.WriteLine("Just close the program, old timer.");
			}
			Console.ReadKey();
			
			Console.WriteLine("Let's play a game (not really). Enter a number up to five decimal places: ");
			double num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter a second number: ");
			double num2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Now I want you to enter an mathematical symbol: '/' for division, '*' for multiplication, '+' for addition, or '-' for subtraction.");
			string operation = Console.ReadLine();
			switch (operation) {
			case "/":
				Console.WriteLine(num1/num2);
				break;
				
			case "*":
				Console.WriteLine(num1*num2);
				break;
				
			case "+":
				Console.WriteLine(num1+num2);
				break;
				
			case "-":
				Console.WriteLine(num1-num2);
				break;
			}
			Console.ReadLine(); 
		}
	}
}
