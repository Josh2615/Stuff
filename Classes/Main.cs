using System;

namespace Classes
{

	class Player {
		private int maxHealth = 100;
		private int minHealth = 0;

		private int _health = 100;
		public int health {
			get{
				return _health;
			}

			set{
				if (value <= minHealth) {
					_health = minHealth;
				} else if (value>= maxHealth) {
					_health = maxHealth;
				} else {
					_health = value;
				}
			}
		}
	}

	class Person {
		private int age;
		private string name;
		public void SayHi(){
			Console.WriteLine ("Hello");
		}
		public Person(int age, string name){
			Console.WriteLine ("{0} is {1} years old.", name, age);
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p1 = new Person (15, "Josh");
			p1.SayHi ();

			DateTime curTime = DateTime.Now;
			Console.WriteLine (curTime);

			Player tom = new Player ();
			Console.WriteLine (tom.health);
			tom.health -= 200;
			Console.WriteLine (tom.health);
			tom.health += 400;
			Console.WriteLine (tom.health);
			tom.health = 50;
			Console.WriteLine (tom.health);

			Console.ReadKey ();
		}
	}
}
