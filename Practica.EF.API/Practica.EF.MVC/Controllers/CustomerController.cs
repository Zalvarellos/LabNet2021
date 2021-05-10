using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practica.EF.Entities;
using Practica.EF.Logic;
using Practica.EF.MVC.Models;

namespace Practica.EF.MVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomersLogic logic = new CustomersLogic();
        // GET: Customer
        public ActionResult Index()
        {
            

            var customers = logic.GetAll();

            List<CustomerView> customerView = customers.Select(c => new CustomerView
            {
                Id = c.CustomerID,
                Nombre = c.ContactName,
                Empresa = c.CompanyName,
                Contacto = c.Phone
            }).ToList();

            return View(customerView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CustomerView customerView)
        {
            try
            {
                var customEntity = new Customers 
                { 
                    CustomerID = customerView.Id.ToUpper(),
                    ContactName = customerView.Nombre,
                    CompanyName = customerView.Empresa,
                    Phone = customerView.Contacto
                };

                logic.Add(customEntity);

                return RedirectToAction("Index", "Customer");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(string id)
        {
            logic.Delete(id);

            return RedirectToAction("Index", "Customer");
        }
    }
}