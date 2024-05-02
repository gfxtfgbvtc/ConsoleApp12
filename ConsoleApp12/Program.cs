using ConsoleApp12;
using System.Xml.Linq;

internal class Program
{

    static void Main(string[] args)
    {
        Dnsstore dnsstore = new Dnsstore();

        Product Yandex = new Ystation();
        Yandex.Name = "Яндекс станция";
        Yandex.Age = 1;
        dnsstore.AddProduct(Yandex);

        Product Kb = new Keyboard();
        Kb.Name = "Razor";
        Kb.Age = 3;
        dnsstore.AddProduct(Kb);

        Product hp = new Headphones();
        hp.Name = "Steelseries";
        hp.Age = 4;
        dnsstore.AddProduct(hp);

        Product m = new Mouse();
        m.Name = "Ardor";
        m.Age = 2;
        dnsstore.AddProduct(m);

        dnsstore.Open();

        dnsstore.User();

        dnsstore.Sell();

        dnsstore.Onn();

        Console.WriteLine();

        dnsstore.InfoKasse();

        dnsstore.SellProduct(50);
        dnsstore.InfoKasse();

        dnsstore.SellProduct(18);
        dnsstore.InfoKasse();

        dnsstore.StealKasse();
        dnsstore.InfoKasse();

    }
}