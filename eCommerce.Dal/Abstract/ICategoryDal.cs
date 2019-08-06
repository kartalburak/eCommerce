using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Entities;

namespace eCommerce.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

        Category Get(int categoryId);

        void Add(Category category);

        void Delete(int categoryId);

        void Update(Category category);
    }
}
