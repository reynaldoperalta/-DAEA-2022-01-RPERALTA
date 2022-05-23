using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //origin de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //ejecucion de consulta
            //EJERCICIO 1
            var query = from p in context.Products
                        select p;
            Console.WriteLine("========================= EJERCICIO 1 ===========================");
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }

            

            //EJERCICIO 2
            var query1 = from p in context.Products
                        where p.Categories.CategoryName == "Beverages"
                        select p;
            Console.WriteLine("========================= EJERCICIO 2 ===========================");
            foreach (var prod in query1)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }

            

            //EJERCICIO 3
            var query3 = from p in context.Products
                         where p.UnitPrice < 20
                        select p;
            Console.WriteLine("========================= EJERCICIO 3 ===========================");
            foreach (var prod in query3)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            }

           

            //INSERTAR DATOS

            //Creacion de consulta
            ////Products np = new Products();
            ////np.ProductName = "Peruvian Coffee";
            ////np.SupplierID = 20;
            ////np.CategoryID = 1;
            ////np.QuantityPerUnit = "10 pkges";
            ////np.UnitPrice = 25;

            ///////EJECUCION DE CONSULTA
            ////context.Products.InsertOnSubmit(np);
            ////context.SubmitChanges();
            ////Console.WriteLine("Nuevo registro en bd:  " + np.ProductID);

            //MODIFICAR REGISTROS
            /*var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            //Ejecucion de consulta
            context.SubmitChanges();
            Console.WriteLine("Registro actualizado : " + product.ProductID);

            Console.ReadKey();

            //ELIMINAR UN PRODUCTO
            var productDel = (from p in context.Products
                              where p.ProductID == 78
                              select p).FirstOrDefault();
            //Ejecucion de consulta
            context.Products.DeleteOnSubmit(productDel);
            context.SubmitChanges();
            Console.WriteLine("Registro eliminado");

            Console.ReadKey();*/

            //Ejercicio I
            var product01 = (from p in context.Products
                             where p.ProductName.Contains("Queso")
                             select p);
            Console.WriteLine("========================= EJERCICIO I ===========================");
            foreach ( var i in product01)
            {
                 Console.WriteLine("ID={0} \t Name={1}", i.ProductID, i.ProductName);
            }

            //Ejerccios II

            var product02 = (from p in context.Products
                             where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                             select p);
            Console.WriteLine("========================= EJERCICIO II ==========================");
            foreach (var i in product02)
            {
                Console.WriteLine("ID={0} \t QPU={1} \t \t \t Name={2}  ", i.ProductID, i.QuantityPerUnit, i.ProductName);
            }

            //Ejercicio III 

            var product03 = (from p in context.Products
                            where p.ProductName.StartsWith("A")
                            select p);
            Console.WriteLine("========================= EJERCICIO III =========================");
            foreach (var i in product03)
            {
                Console.WriteLine("ID={0} \t Name={1}", i.ProductID, i.ProductName);
            }

            //Ejercicio IV

            var product04 = (from p in context.Products
                           where p.UnitsInStock == 0
                           select p);
            Console.WriteLine("========================= EJERCICIO IV ==========================");
            foreach (var i in product04)
            {
                Console.WriteLine("ID={0} \t Stock={1} \t Name={2}", i.ProductID, i.UnitsInStock, i.ProductName);
            }

            //Ejercicio V

            var product05 = (from p in context.Products
               where p.Discontinued == true
               select p);
            Console.WriteLine("========================= EJERCICIO V ===========================");
            foreach (var i in product05)
            {
                Console.WriteLine("ID={0} \t Discontinued={1} \t Name={2}", i.ProductID, i.Discontinued, i.ProductName);
            }
            Console.WriteLine("=======================================================================================================");
            Console.WriteLine("=======================================================================================================");
            //Tarea 1 

            var productT1 = from p in context.Products
                          join s in context.Suppliers on p.SupplierID equals s.SupplierID
                          join c in context.Categories on p.CategoryID equals c.CategoryID
                          where c.CategoryName == "Dairy Products"
                          select new
                          {
                              ProductID = p.ProductID,
                              CategoryName = c.CategoryName,
                              Nproduct = p.ProductName,
                              Nproveerdor = s.CompanyName,
                          };
            Console.WriteLine("================================================== TAREA 1 =================================================");
            foreach (var i in productT1)
            {
                Console.WriteLine("ID ={0} \t NameCat={1} \t NameProd ={2} \t \t \t NameProv = {3}", i.ProductID,i.CategoryName, i.Nproduct, i.Nproveerdor);
            }
            
            //Tarea 2 
            var productT2 = from p in context.Products
                          join s in context.Suppliers on p.SupplierID equals s.SupplierID
                          where s.Country == "USA"
                          select new
                          {
                              ProductID = p.ProductID,
                              Country = s.Country,
                              Nproduct = p.ProductName,
                              Nproveerdor = s.CompanyName,
                          };
            Console.WriteLine("================================================= TAREA 2 =================================================");
            foreach (var i in productT2)
            {
                Console.WriteLine("ID ={0} \t Country ={1} \t NameProd ={2} \t \t \t NameProv = {3}", i.ProductID, i.Country, i.Nproduct, i.Nproveerdor);
            }
            Console.ReadKey();
        }
    }
}
