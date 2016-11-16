using PagedList;
using SportsStore.Domainn.Abstract;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 4;

        public HomeController(IProductsRepository repository)
        {
            this.repository = repository;
        }
        public ActionResult ListProducts(string searchString, int page = 1)
        {
            var product = repository.Products;

            if (!String.IsNullOrEmpty(searchString))
            {
                product = product.Where(x=>x.Name.ToLower().StartsWith(searchString));
            }

            product = product.OrderBy(x=>x.ProductId).ToPagedList(page, PageSize);

            return View(product);
        }
    }
}