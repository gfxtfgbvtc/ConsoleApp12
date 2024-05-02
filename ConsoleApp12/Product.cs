using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal abstract class Product
    {

        private int age;
        private string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Возраст не может быть меньше 0");
                else
                    age = value;
            }

        }
        public void Info()
        {
            if (name != null)
                Console.WriteLine($"Показывают товар {Name}");
            if (age != 0)
                Console.WriteLine($"Изготовлен {Age} лет назад");
        }
        public virtual void Unpacking()
        {
            Console.WriteLine($"{Name} распаковали");
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} играет ");
        }
        public virtual void Sound()
        {
            Console.WriteLine($"{Name} издает звуки ");
        }
        public virtual void On()
        {
            Console.WriteLine($"{Name} выключается");
        }
    }
}
