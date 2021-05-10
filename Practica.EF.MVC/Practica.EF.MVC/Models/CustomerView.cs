using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.EF.MVC.Models
{
    public class CustomerView
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
    }
}