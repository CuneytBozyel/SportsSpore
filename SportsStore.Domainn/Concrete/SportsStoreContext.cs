using System.Data.Entity;

namespace SportsStore.Domainn.Concrete
{
    class SportsStoreContext:DbContext
    {
        public SportsStoreContext() : base("name=SportsStoreContext")
        {

        }
        public DbSet<Entities.Product> Products { get; set; }
    }
}
