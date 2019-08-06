using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Dal.Abstract;
using eCommerce.Entities;

namespace eCommerce.Dal.Concrete.Entities
{
    public class EfCategoryDal : ICategoryDal
    {
        ECommerceContext db = new ECommerceContext();

        public List<Category> GetAll()
        {
            return db.Category.ToList();
        }

        public Category Get(int categoryId)
        {
            return db.Category.Find(categoryId);
        }

        public void Add(Category category)
        {
            try
            {
                db.Category.Add(category);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                string exception = e.Message;
            }

        }

        public void Delete(int categoryId)
        {
            Category category = db.Category.Find(categoryId);
            if (category != null)
            {
                try
                {
                    db.Category.Remove(category);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string exception = e.Message;
                }
            }
          
        }

        public void Update(Category cat)
        {
            try
            {
                Category category = db.Category.Find(cat.CategoryId);
                if (category != null)
                {
                    category.CategoryDescription = cat.CategoryDescription;
                    category.CategoryName = cat.CategoryName;
                    category.PictureId = cat.PictureId;

                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                string exception = e.Message;
            }

        }
    }
}
