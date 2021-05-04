using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.LINQ.Data;

namespace Practica.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindContext();

            #region query1
            var query1 = from customer in db.Customers
                         select customer;
            
            foreach (var customer in query1)
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.ContactTitle} / {customer.Address} / {customer.City} / {customer.Region} / {customer.PostalCode}" +
                    $" / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }
            #endregion

            #region query2
            var query2 = from product in db.Products
                            where product.UnitsInStock == 0
                            select product;

            Console.WriteLine("Productos sin stock: ");

            foreach (var product in query2)
            {
                Console.WriteLine($"ID: {product.ProductID} \n Producto: {product.ProductName} \n U/en Orden: {product.UnitsOnOrder} ");
            }

            #endregion

            #region query3
            var query3 = from product in db.Products
                            where product.UnitsInStock != 0 && product.UnitPrice > 3
                            select product;

            foreach (var product in query3)
            {
                Console.WriteLine($"ID: {product.ProductID} \n Producto: {product.ProductName} \n Precio X Unidad: {product.UnitPrice} ");
            }
            #endregion

            #region query4
            var query4 = from customer in db.Customers
                            where customer.Region == "WA"
                            select customer;

            foreach (var customer in query4)
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.ContactTitle} / {customer.Address} / {customer.City} / {customer.Region} / {customer.PostalCode}" +
                    $" / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }
            #endregion

            #region query5
            var query5 = db.Products.FirstOrDefault(c => c.ProductID == 789);

            try
            {
                Console.WriteLine(query5.ProductID);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No se encotro un Producto con esa ID...");

            }
            finally
            {
                Console.WriteLine("\n Error atrapado!");
            }
            #endregion

            #region query6
            var query6 = from customer in db.Customers
                            select customer;

            foreach (var customer in query6)
            {
                Console.WriteLine($"Cliente: {customer.ContactName.ToLower()} / {customer.ContactName.ToUpper()}");
            }

            #endregion

            #region query7
            var date = DateTime.Parse("1997/1/1");

            var query7 = from customer in db.Customers
                            join order in db.Orders
                            on customer.CustomerID
                            equals order.CustomerID
                            where customer.Region == "WA" && (order.OrderDate > date) 
                            select new
                            {
                                customer.ContactName,
                                customer.Region,
                                order.OrderID,
                                order.OrderDate,
                                order.Order_Details
                            };

            foreach (var customer in query7)
            {
                Console.WriteLine($"Cliente: {customer.ContactName} | Pedido: {customer.OrderID} | Region: {customer.Region} | Fecha de Pedido: {customer.OrderDate} | Detalles de Pedido: {customer.Order_Details}");
            }
            #endregion

            #region query8
            var query8 = db.Customers.Where(c => c.Region == "WA").Take(3);

            foreach (var customer in query8)
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.ContactTitle} / {customer.Address} / {customer.City} / {customer.Region} / {customer.PostalCode}" +
                    $" / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }
            #endregion

            #region query9
            var query9 = db.Products.OrderBy(c => c.ProductName);

            foreach (var producto in query9)
            {
                Console.WriteLine($"Producto: {producto.ProductName} | Precio:" +
                    $" {producto.UnitPrice}");
            }
            #endregion

            #region query10
            var query10 = db.Products.OrderByDescending(c => c.UnitsInStock);

            foreach (var producto in query10)
            {
                Console.WriteLine($"Producto: {producto.ProductName} \nUnidades en Stock:" +
                    $" {producto.UnitsInStock}");
            }
            #endregion

            #region query11
            var query11 = from product in db.Products
                          join category in db.Categories
                            on product.CategoryID
                                equals category.CategoryID
                          select new
                          {
                              product.ProductName,
                              category.CategoryName
                          };

            foreach (var prod in query11)
            {
                Console.WriteLine( $"{prod.CategoryName} | {prod.ProductName} " );
            }
            #endregion

            #region query12
            var query12 = db.Products.First();

            Console.WriteLine($"ID: {query12.ProductID} \nProducto: {query12.ProductName}");
            #endregion

            Console.ReadLine();
        }
    }
}
