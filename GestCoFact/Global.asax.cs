using LibModel;
using Repository;
using Repository.GestionCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GestCoFact
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mock();
        }
        

        protected void Mock()
        {
            var cache = new InMemoryCache();

            ClientRepository lClientRepository = new ClientRepository();
            cache.GetOrSet("ListeModelClient", () => lClientRepository.GetClients());

            FactureRepository lFactureRepository = new FactureRepository();
            cache.GetOrSet("ListeModelFactures", () => lFactureRepository.GetFactures());

            CommandeRepository lCommandeRepository = new CommandeRepository();
            cache.GetOrSet("ListeModelCommandes", () => lCommandeRepository.GetCommandes());
            ;
        }

    }

}
