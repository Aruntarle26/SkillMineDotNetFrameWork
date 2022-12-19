using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.GenericCollection
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"id: {Id}, name: {Name}, price:{Price}";

        }


        public static void Main(string[] args)
        {

            List<Product> l = new List<Product>();

            l.Add(new Product { Id = 100, Name = "pen", Price = 5000 });
            l.Add(new Product { Id = 101, Name = "bag", Price = 1500 });
            l.Add(new Product { Id = 102, Name = "pecile", Price = 5000 });
            l.Add(new Product { Id = 103, Name = "rubber", Price = 200 });
            foreach (Product p in l)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine("price less than 2000rs............");
            foreach (Product p in l)
            {
                if (p.Price < 2000)
                    Console.WriteLine(p);
            }


        }

    }
}
