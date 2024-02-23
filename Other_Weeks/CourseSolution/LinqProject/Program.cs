using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryId = 1, CategoryName= "Computer" },
                new Category {CategoryId = 2, CategoryName= "PC" },
                new Category {CategoryId = 3, CategoryName= "Tablet" },
            };
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 2, ProductName ="iphone ", QuantityPerUnit="256 gb", UnitInStock= 3, UnitPrice= 10000  },
                new Product { ProductId = 1, CategoryId = 1, ProductName ="HP", QuantityPerUnit="Victus", UnitInStock= 4, UnitPrice= 1000  },
                new Product { ProductId = 1, CategoryId = 4, ProductName ="ipad ", QuantityPerUnit="256 gb", UnitInStock= 4, UnitPrice= 100000  },

            };

            Console.WriteLine( GetProductsWithLinq(products));

            var wihtoutResult = GetProductsWithoutLinq(products);
            foreach(var product in wihtoutResult)
            {
                Console.WriteLine( product.ProductName );
            }

            Console.WriteLine("---------Algoritmik-------------");

        foreach (var product in products)
            {
                if (product.UnitPrice > 1000 && product.UnitInStock >3)
                { 
                Console.WriteLine(product.ProductName);
                }
            }
            //static List<Product> GetProducts()
            //{


            //}
            Console.WriteLine("---------------LINQ (Language integrated query) -----------------");

        var result = products.Where(p => p.CategoryId == 1 && p.ProductName == "HP");
        foreach(var product in result)
            {
            Console.WriteLine(product.ProductName);

            }
        Console.ReadLine();
        }
        static List<Product> GetProductsWithoutLinq(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 1000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);                
                }
            }
            return filteredProducts;

        }
        
        static List<Product> GetProductsWithLinq(List<Product> products) { 

            return products.Where(p => p.CategoryId == 1 && p.ProductName == "HP").ToList();
           
        
        }


    }

    class Product
        {
            public int ProductId { get; set; }

            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }

            public int UnitInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

        }
}
