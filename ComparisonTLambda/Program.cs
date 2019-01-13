using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> item = new List<Product>();

            item.Add(new Product("TV", 900.00));
            item.Add(new Product("Geladeira", 1200.00));
            item.Add(new Product("Tablet", 1630.00));

            // public delegate int Comparison<in T>(T x, T y);
            Comparison<Product> comp = (p1, p2) => p1.Name.ToString().ToUpper().CompareTo(p2.Name.ToString().ToUpper());

            item.Sort(comp);

            foreach (Product prod in item)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
