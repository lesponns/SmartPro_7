using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double item_price, last_price;

            Console.Write("Ürün fiyatı: ");
            item_price = double.Parse(Console.ReadLine());

            if (item_price < 100 && item_price > 0)
            {
                Console.Clear();
                last_price = item_price + 35;
                Console.WriteLine("Kargo ücreti 35tl dir. Toplam borcunuz: "+last_price+"tl'dir.");
            }
            else if (item_price >= 100)
            {
                Console.Clear();
                Console.WriteLine("Kargo ücreti yoktur. \nToplam borcunuz: " + item_price +"tl'dir.");
            }
            Console.ReadKey();
        }
    }
}
