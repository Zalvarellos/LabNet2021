using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.EF.Entities;
using Practica.EF.Logic;

namespace Practica.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
             CategoriesLogic categoriesLogic = new CategoriesLogic();
             CustomersLogic customersLogic = new CustomersLogic();
            
             Console.WriteLine("Lista de categorias:");

             foreach (Categories category in categoriesLogic.GetAll())
             {
                  Console.WriteLine($"{category.CategoryName} - {category.Description}");
             }

            Console.WriteLine();

            Console.WriteLine("Lista de clientes: ");

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.Address} / {customer.City}" +
                    $"{customer.Region} / {customer.PostalCode} / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }

            Console.WriteLine("Alta de categoria: ");

            categoriesLogic.Add(new Categories
            {
                CategoryID = 9,
                CategoryName = "Videojuegos",
                Description = "Clasicos de los pibes, tipo mario bros, sunsetriders, tetris, etc.",
                Picture = null
            });

            foreach (Categories category in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{category.CategoryName} - {category.Description}");
            }

            Console.WriteLine("Modificacion de categoria : ");

            categoriesLogic.Update(new Categories
            {
                CategoryID = 9,
                Description = "Juegos de azar y mujersuelas"
            });

            Console.WriteLine();

            foreach (Categories category in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{category.CategoryName} - {category.Description}");
            }

            Console.WriteLine("Se elimino la categoria creada: ");

            categoriesLogic.Delete(9);

            
            Console.WriteLine("Alta de cliente: ");
            
            customersLogic.Add(new Customers
            {
                CustomerID = "ZERAX",
                CompanyName = "Zerax Arcade",
                ContactName = "Marcelo Fafafa",
                ContactTitle = "Owner",
                Address = "Siempre Viva 265",
                City = "Springfield",
                Region = null,
                PostalCode = "45568",
                Country = "USA",
                Phone = "(503) 555-8549",
                Fax = null
            });
            
            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.Address} / {customer.City}" +
                    $"{customer.Region} / {customer.PostalCode} / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }

            customersLogic.Update(new Customers
            {
                CustomerID = "ZERAX",
                Address = "Alsina 5498"
            });

            Console.WriteLine("Modificacion: ");

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} / {customer.CompanyName} / {customer.ContactName} / {customer.Address} / {customer.City}" +
                    $"{customer.Region} / {customer.PostalCode} / {customer.Country} / {customer.Phone} / {customer.Fax}");
            }

            customersLogic.Delete("ZERAX");

            Console.WriteLine($"Se elimino el cliente: ");
            
            Console.ReadLine();



        }
    }
}
