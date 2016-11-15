using SportsStore.Domainn.Abstract;
using System.Collections.Generic;
using SportsStore.Domainn.Entities;

namespace SportsStore.Domainn.Concrete
{
    public class EFProductRepository : IProductsRepository
    {

        private SportsStoreContext context = new SportsStoreContext();

        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
