using PagedList;
using SportsStore.Domainn.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 4;

        public HomeController(IProductsRepository repository )
        {
            this.repository = repository;
        }
        public ActionResult ListProducts(int page=1)
        {
            var product = repository.Products.OrderBy(x => x.ProductId).ToPagedList(page,PageSize);
            return View(product);
        }
    }
}