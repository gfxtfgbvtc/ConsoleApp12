using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Ystation : Product
    {


        public override int Age
        {

            get
            {
                return base.Age;
            }
            set
            {
                if (value > 0 && value < 15)
                    base.Age = value;
                else
                    Console.WriteLine("Данный возраст яндекс станции не позволителен (0-3)");
            }
        }

        public override void Unpacking()
        {
            Console.WriteLine($"Распакова {Name} станции");
        }
        public override void On()
        {
            Console.WriteLine($" {Name} сообщает о включении");
        }
        public override void Sound()
        {
            Console.WriteLine($" {Name} Включает музыку");
        }
        public override void Play()
        {
            Console.WriteLine($" {Name} Включает ролик по просьбе");
        }
    }
}
