using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfProds = int.Parse(Console.ReadLine()); 
            List<string> products = new List<string>();
            for (int i = 0; i < countOfProds; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();
            for (int i = 0; i < countOfProds; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }

        }
    }
}
