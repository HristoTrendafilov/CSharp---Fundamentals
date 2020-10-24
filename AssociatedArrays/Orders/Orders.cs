using System.Linq;
using System.Collections.Generic;
using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalProduct = new Dictionary<string, Product>();


            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();

                if (command[0] == "buy")
                {
                    break;
                }
                string productName = command[0];
                double productPrice = double.Parse(command[1]);
                double productQuantity = double.Parse(command[2]);

                if (!totalProduct.ContainsKey(productName))
                {
                    var newProduct = new Product(productPrice, productQuantity);

                    totalProduct.Add(productName, newProduct);
                }
                else
                {
                    totalProduct[productName].Quantity += productQuantity;
                    totalProduct[productName].Price = productPrice;
                }

            }
            foreach (var product in totalProduct)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Quantity*product.Value.Price:f2}");
            }
        }
        class Product
        {
            public Product(double productPrice, double productQuantity)
            {
                Price = productPrice;
                Quantity = productQuantity;
            }
            public double Price { get; set; }
            public double Quantity { get; set; }
            
          
        }
    }
}
