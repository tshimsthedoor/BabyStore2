using BabyStore2.Models;
using System.Data.Entity;

namespace BabyStore2.DAL
{
    public class StoreContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}