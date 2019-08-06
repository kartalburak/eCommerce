using eCommerce.Entities;
using System.Data.Entity;

namespace eCommerce.Dal.Concrete.Entities
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("ECommerceContext")
        {

        }

        #region DbSets
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<Brand> Brand { get; set; }

        public virtual DbSet<Cargo> Cargo { get; set; }

        public virtual DbSet<Cart> Cart { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }

        public virtual DbSet<FeatureType> FeatureType { get; set; }

        public virtual DbSet<FeatureValue> FeatureValue { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<OrderStatus> OrderStatus { get; set; }

        public virtual DbSet<Picture> Picture { get; set; }

        public virtual DbSet<ProductFeature> ProductFeature { get; set; }


        #endregion

    }
}