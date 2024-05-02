using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Keyboard : Product
    {

        public override int Age
        {

            get
            {
                return base.Age;
            }
            set
            {
                if (value > 0 && value < 10)
                    base.Age = value;
                else
                    Console.WriteLine("Данный возраст клавиатуры ");
            }
        }

        public override void Unpacking()
        {
            Console.WriteLine($"Клавиатура {Name} заблокировалась");
        }
        public override void Play()
        {
            Console.WriteLine($"Клавиатура {Name} переливается");
        }
        public override void On()
        {
            Console.WriteLine($"Проверка клавиатуры {Name} на исправность .");
        }
    }
}