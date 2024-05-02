using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Mouse : Product
    {

        public new int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 0 && value < 5)
                    base.Age = value;
                else
                    Console.WriteLine("Технике не может быть меньше нуля лет");
            }
        }


        public new void Eat()
        {
            Console.WriteLine($"Мышка {Name} мигает об отсутствии батареек");
        }
        public new void Move()
        {
            Console.WriteLine($"Мышка {Name} меняет цвет из-за dpi");
        }
        public void Uuuu()
        {
            Console.WriteLine($"Сообщение {Name} о подключении");
        }
    }

}
