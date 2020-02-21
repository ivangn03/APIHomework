using DI.Moduls;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiService.Infrastructure
{
    public class DR : IDependencyResolver
    {
        IKernel kernel;
        public DR()
        {
            kernel = new StandardKernel(new MyDIModule());

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