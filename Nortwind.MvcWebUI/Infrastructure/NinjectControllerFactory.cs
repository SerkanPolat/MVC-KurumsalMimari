using Ninject;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Nortwind.CrossCuttingConcerns.Logging;
using Nortwind.Dal.Abstract;
using Nortwind.Dal.Concrete.EntityFramework;
using Nortwind.Dll.Concrete;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nortwind.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
           // this.ninjectKernel = new StandardKernel();

            ninjectKernel = new StandardKernel(new NinjectSettings { LoadExtensions = true });
            //AddBllBindings();

            AddServiceBindings();
        }

        private void AddBllBindings()
        {
            ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProduct());
            ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoriesDal", new EfCategory());
            ninjectKernel.Bind<IAuthenticationService>().To<AuthenticationManager>().WithConstructorArgument("authenticationDal", new EfAuthenticationDal());
            //Loglama Kaydediliyor.
            ninjectKernel.Intercept(p => (true)).With(new LoggingInterceptor());
        }

        private void AddServiceBindings()
        {
            ninjectKernel.Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
            ninjectKernel.Bind<ICategoryService>().ToConstant(WcfProxy<ICategoryService>.CreateChannel());
            ninjectKernel.Bind<IAuthenticationService>().ToConstant(WcfProxy<IAuthenticationService>.CreateChannel());
           
        }


        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

    }
}