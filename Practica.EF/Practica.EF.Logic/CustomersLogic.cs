using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.EF.Data;
using Practica.EF.Entities;

namespace Practica.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);

            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var clienteAEliminar = context.Customers.SingleOrDefault(c => c.CustomerID == id);

            context.Customers.Remove(clienteAEliminar);

            context.SaveChanges();
        }

        public void Update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            customerUpdate.Address = customer.Address;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
