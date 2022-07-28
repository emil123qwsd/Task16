using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();

            }
            Products[] products = JsonSerializer.Deserialize<Products[]>(jsonString);

            Products maxProducts = products[0];
            foreach (Products e in products)
            {
                if (e.Price > maxProducts.Price)
                {
                    maxProducts = e;
                }

            }
            Console.WriteLine($"{maxProducts.Code} {maxProducts.Title} {maxProducts.Price}");
            Console.ReadKey();
        }
    }
}
