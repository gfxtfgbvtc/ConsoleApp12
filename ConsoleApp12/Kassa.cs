using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Kassa
    {
        private int cash;
        private int technicalCount = 89;
        private int price = 1500;

        public Kassa(int technicalCount)
        {
            this.technicalCount = technicalCount;
        }

        public void InfoKasse()
        {
            Console.WriteLine($"Баланс кассы {cash} рублей  {technicalCount}  ");
        }

        public void SellProduct(int quantity)
        {
            if (technicalCount < quantity)
                Console.WriteLine($"Увы, но сегодня только осталось всего {technicalCount} техники ");
            else
            {
                technicalCount -= quantity;
                cash += quantity * price;
                Console.WriteLine($"Продажа {quantity} техники на сумму {quantity * price} рублей");
            }
        }

        public void StealKasse()
        {
            Console.WriteLine($"Из кассы было украдено {cash} рублей");
            cash -= cash;
        }
    }
}

