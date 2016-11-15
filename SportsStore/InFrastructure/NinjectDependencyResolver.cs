using Moq;
using Ninject;
using SportsStore.Domainn.Abstract;
using SportsStore.Domainn.Concrete;
using SportsStore.Domainn.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportsStore.InFrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}