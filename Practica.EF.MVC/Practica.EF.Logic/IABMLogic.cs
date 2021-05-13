using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.EF.Entities;

namespace Practica.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T newCustomer);
        void Update(T category);
        void Delete(string id);

        void Delete(int id);
    }
}
