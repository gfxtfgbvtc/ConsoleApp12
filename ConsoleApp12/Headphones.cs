using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Headphones : Product
    {

        public new int Age
        {

            get
            {
                return base.Age;
            }
            set
            {
                if (value > 0 && value < 7)
                    base.Age = value;
                else
                    Console.WriteLine("Данный возраст змей не позволителен (0-7)");
            }
        }

        public new void Move()
        {
            Console.WriteLine($"Наушники {Name} ярко переливаются");
        }

        public new void Eat()
        {
            Console.WriteLine($"Наушники {Name} перешли на тихий режим");
        }

        public new void Unsleep()
        {
            Console.WriteLine($"Наушики {Name} мигают красным");
        }
    }
}
