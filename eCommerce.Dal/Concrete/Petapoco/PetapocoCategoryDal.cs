using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using PetaPoco;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Dal.Concrete.Petapoco
{
    public class PetapocoCategoryDal : ICategoryDal
    {
        private Database _context = new Database("ECommerceContext");

        public List<Category> GetAll()
        {

            var sql = Sql.Builder.Append("Select * from Category");
            return _context.Query<Category>(sql).ToList();


        }

        public Category Get(int CategoryId)
        {

            var sql = Sql.Builder.Append("Select * from Category where CategoryId=@0", CategoryId);
            return _context.Single<Category>(sql);

        }

        public void Add(Category Category)
        {

            _context.Insert(Category);

        }

        public void Delete(int CategoryId)
        {

            _context.Delete(CategoryId);

        }

        public void Update(Category Category)
        {

            Category _category = new Category();
            _category.CategoryName = Category.CategoryName;
            _category.CategoryDescription = Category.CategoryDescription;
            _category.PictureId = Category.PictureId;


            _context.Update(_category);

        }
    }
}
