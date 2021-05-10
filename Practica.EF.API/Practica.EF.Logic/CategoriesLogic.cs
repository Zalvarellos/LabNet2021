using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.EF.Data;
using Practica.EF.Entities;

namespace Practica.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Categories newCategory)
        {
            context.Categories.Add(newCategory);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoriaAEliminar = context.Categories.SingleOrDefault(c => c.CategoryID == id);

            context.Categories.Remove(categoriaAEliminar);

            context.SaveChanges();
        }

        public void Update(Categories category)
        {
            var categoryUpdate = context.Categories.SingleOrDefault(c => c.CategoryID == category.CategoryID);

            categoryUpdate.Description = category.Description;

            context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
