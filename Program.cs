using groot;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        groots[] goods = new groots[x];

        for (int i = 0; i < x; i++)
        {
            groots predmet = new groots();
            Console.WriteLine("Напишите год выпуска/появления товара/услуги");
            predmet.data = Console.ReadLine();
            Console.WriteLine("Напишите название товара/услуги");
            predmet.name = Console.ReadLine();
            Console.WriteLine("Напишите цену");
            predmet.price = Console.ReadLine();
            
            goods[i] = predmet;
        }
        var json = JsonSerializer.Serialize(goods);
        File.WriteAllText("goods.json", json);

        controller deserial = new controller();
        string path = "goods.json";


        var t = deserial.Load(path);


        if (t == null)
            return;

        foreach (var item in t)
        {
            Console.WriteLine("{0} {1} {2} {3}", item.name, item.data, item.price);
        }

    }
}


