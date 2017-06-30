using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_And_Set
{
    class Person {
        private int health = 100;
        private int maxHealth = 100;
        private int minHealth = 0;

        public int _health {
            get {
                return health;
            }
            set {
                if (value >= maxHealth)
                {
                    health = maxHealth;
                }
                else if (value <= minHealth)
                {
                    health = minHealth;
                }
                else
                {
                    health = value;
                }
            }
        }
        public void Damage(int dmg) {
            _health -= dmg;
        }

        public void Heal(int healAmount) {
            _health += healAmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Damage(50);
            Console.WriteLine(p1._health);
            p1.Damage(400);
            Console.WriteLine(p1._health);
            p1.Heal(2000);
            Console.WriteLine(p1._health);

            Console.ReadKey();
        }
    }
}
