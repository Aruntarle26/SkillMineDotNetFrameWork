using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.CollectionsStudy.MiniP
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        public override string ToString()
        {
            return$"Product id:{ProductId}  product Name: {ProductName}  Product Cost: {ProductCost}"; 
        }

    }
    public class Catagary
    {
        public string CatagaryName { get; set; }
        public List<Product> product = new List<Product>();
        public override string ToString()
        {
            return $"Catagary is: {CatagaryName}"; 
        }
    }

    class CategaryWithProductDetails
    {
        /*static void Main(string[] args)
        {
            List<Catagary> c = new List<Catagary>();
            c.Add(new Catagary
            { 
                CatagaryName="Ferniture",
                product = { new Product { ProductId = 100, ProductName = "chair", ProductCost = 500.00 },
                 new Product { ProductId = 101, ProductName = "table", ProductCost = 700.00 },
                 new Product { ProductId = 102, ProductName = "coat", ProductCost = 800.00 },
                 new Product { ProductId = 103, ProductName = "tvTable", ProductCost = 900.00 }}
            });
            c.Add(new Catagary
            {
                CatagaryName = "Mobile",
                product = { new Product { ProductId = 200, ProductName = "samsung", ProductCost = 12500.00 },
                 new Product { ProductId = 201, ProductName = "nokia", ProductCost = 34700.00 },
                 new Product { ProductId = 202, ProductName = "realme", ProductCost =56800.00 },
                 new Product { ProductId = 203, ProductName = "redme", ProductCost = 34900.00 }}
            });
            c.Add(new Catagary
            {
                CatagaryName = "clothe",
                product = { new Product { ProductId = 300, ProductName = "pant", ProductCost = 12500.00 },
                 new Product { ProductId = 301, ProductName = "shirt", ProductCost = 34700.00 },
                 new Product { ProductId = 302, ProductName = "payjama", ProductCost =56800.00 },
                 new Product { ProductId = 303, ProductName = "sweater", ProductCost = 34900.00 }}
            });
            foreach (Catagary cr in c)
            {
                Console.WriteLine(cr);
                foreach (Product pr in cr.product)
                {
                    Console.WriteLine(pr);
                }
                Console.WriteLine("----------------------------");
            }


        }*/
    }


   
}
