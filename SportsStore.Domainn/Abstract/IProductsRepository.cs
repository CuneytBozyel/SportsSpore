using SportsStore.Domainn.Entities;
using System.Collections.Generic;

namespace SportsStore.Domainn.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
