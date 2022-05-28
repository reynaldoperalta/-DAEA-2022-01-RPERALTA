using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;

                //Ejercicio 01
                IQueryable<string> productNames = from p in products select p.Name;

                Console.WriteLine("Ejercicio 01 - Productos: ");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 02
                IQueryable<string> productNames2 = products.Select(p => p.Name);
                Console.WriteLine("Ejercicio 02 - Productos: ");
                foreach (var productName in productNames2)
                {
                    Console.WriteLine(productName);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 03
                IQueryable<Product> productsQuery = from p in products select p;
                IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");
                Console.WriteLine("Ejercicio 03 - Productos de tamaño 'L': ");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 10
                int?[] productModelIds = { 19, 26, 118 };
                var products2 = from p in AWEntities.Product
                                where productModelIds.Contains(p.ProductModelID)
                                select p;                            
                Console.WriteLine("Ejercicio 10----------- ");
                foreach (var product in products2)
                {
                    Console.WriteLine("{0}: {1} ",
                        product.ProductModelID, product.ProductModelID);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");
            }
            //Console.ReadKey();


            String color = "Red";
            int orderQtyMin = 2;
            int orderQtyMax = 6;
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            
            {
                //Ejercicio 04
                IQueryable<Product> productsQuery = from product in context.Product select product;
                Console.WriteLine("Ejercicio 04 - Productos: ");
                foreach (var prod in productsQuery)
                {
                    Console.WriteLine(prod.Name);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 05
                var query = from product in context.Product
                            select new
                            {
                                ProductId = product.ProductID,
                                ProductName = product.Name
                            };
                Console.WriteLine("Ejercicio 05 - Información de productos: ");
                foreach (var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product Name: {1} ", 
                        productInfo.ProductId, productInfo.ProductName);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 08             
                /*var query2 = from order in context.SalesOrderDetail
                            where order.OrderQty > orderQtyMin &&
                            order.OrderQty < orderQtyMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                OrderQty = order.OrderQty
                            };
                Console.WriteLine("Ejercicio 08----------- ");
                foreach (var order in query2)
                {
                    Console.WriteLine("Order ID: {0} Order quantity: {1} ",
                        order.SalesOrderID, order.OrderQty);
                }*/
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 09             
                var query3 = from product in context.Product
                             where product.Color == color
                             select new
                             {
                                 Name = product.Name,
                                 ProductNumber = product.ProductNumber,
                                 ListPrice = product.ListPrice
                             };
                Console.WriteLine("Ejercicio 09----------- ");
                foreach (var product in query3)
                {
                    Console.WriteLine("Name: {0}  ", product.Name);
                    Console.WriteLine("Product number: {0}  ", product.ProductNumber);
                    Console.WriteLine("List price: ${0}  ", product.ListPrice);
                    Console.WriteLine("");
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 12
                IQueryable<Decimal> sortedPrices = from p in context.Product 
                                                   orderby p.ListPrice descending 
                                                   select p.ListPrice;
                Console.WriteLine("Ejercicio 12 - Lista de precios desde el más alto al más bajo: ");
                foreach (Decimal price in sortedPrices)
                {
                    Console.WriteLine(price);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 14
                var products = context.Product;
                var query4 = from product in products
                             group product by product.Style into g
                             select new
                             {
                                 Style = g.Key,
                                 AverageListPrice = g.Average(product => product.ListPrice)
                             };
                Console.WriteLine("Ejercicio 14----------- ");
                foreach (var product in query4)
                {
                    Console.WriteLine("Estilo: {0} Precio promedio: {1} ",
                        product.Style, product.AverageListPrice);
                }
                //Console.ReadKey();

                Console.WriteLine("#####################################################################################");

                //Ejercicio 15
                var products2 = context.Product;
                var query5 = from product in products
                             group product by product.Color into g
                             select new
                             {
                                 Color = g.Key,
                                 ProductCount = g.Count()
                             };
                Console.WriteLine("Ejercicio 15----------- ");
                foreach (var product in query5)
                {
                    Console.WriteLine("Color: {0} \t Cantidad: {1} ",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();

            }
            
        }

    }
}
