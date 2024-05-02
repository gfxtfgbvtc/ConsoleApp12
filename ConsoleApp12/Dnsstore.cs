using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Dnsstore
    {
        private List<Product> Prod = new List<Product>();
        private Kassa kasse = new Kassa(5000);

        public void AddProduct(Product product)
        {
            Prod.Add(product);
            Console.WriteLine($"товар {product.Name} добавлен на склад в магазине");
        }

        public void Open()
        {
            Console.WriteLine("############################################");
            Console.WriteLine("Магазин открывается");
            foreach (var item in Prod)
            {
                item.Unpacking();
            }
            Console.WriteLine("############################################");
            Console.WriteLine();
        }

        public void User()
        {
            Console.WriteLine("############################################");
            Console.WriteLine("В магазин приходит покупатель ");
            foreach (var item in Prod)
            {
                item.Play();
            }
            Console.WriteLine("############################################");
            Console.WriteLine();
        }

        public void Onn()
        {
            Console.WriteLine("############################################");
            Console.WriteLine("Включение техники");
            foreach (var item in Prod)
            {
                item.On();
            }
            Console.WriteLine("############################################");
            Console.WriteLine();
        }

        public void Sell()
        {
            Console.WriteLine("############################################");
            Console.WriteLine("Продажа товара");
            foreach (var item in Prod)
            {
                item.Sound();
            }
            Console.WriteLine("############################################");
            Console.WriteLine();
        }

        public void InfoKasse()
        {
            kasse.InfoKasse();
        }
        public void SellProduct(int quantity)
        {
            kasse.SellProduct(quantity);
        }
        public void StealKasse()
        {
            this.Sell();
            kasse.StealKasse();
        }

    }
}

