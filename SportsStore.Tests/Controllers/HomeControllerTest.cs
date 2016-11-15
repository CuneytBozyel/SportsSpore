using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore;
using SportsStore.Controllers;
using Moq;
using SportsStore.Domainn.Abstract;
using SportsStore.Domainn.Entities;

namespace SportsStore.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void can_pagenin()
        {
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();

            mock.Setup(m => m.Products).Returns(new Product[] {

                new Product {ProductId=1,Name="İnci" },
                new Product {ProductId=2,Name="İnci" },
                new Product {ProductId=3,Name="İnci" },
                new Product {ProductId=4,Name="İnci" },
                new Product {ProductId=5,Name="İnci" },
                new Product {ProductId=6,Name="İnci" },
                new Product {ProductId=7,Name="İnci" },
                new Product {ProductId=8,Name="İnci" },
                new Product {ProductId=9,Name="İnci" },
                new Product {ProductId=10,Name="İnci" },
                new Product {ProductId=11,Name="İnci" },
                new Product {ProductId=12,Name="İnci" },

            });

            HomeController controller = new HomeController(mock.Object);
            controller.PageSize = 3;

            IEnumerable<Product> product = (IEnumerable<Product>)controller.ListProducts(2);

            Product[] prodArray = product.ToArray();

            //Assert.IsTrue(prodArray.Length == 4);
            Assert.Equals(prodArray[0].Name, "İnci");
        }
       

    }
}
