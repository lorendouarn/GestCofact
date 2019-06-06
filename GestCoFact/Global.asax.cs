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

            //Mock et mise en cache facture
            FactureRepository lFactureRepository = new FactureRepository();
            IList<Facture> listeTouteFactures = lFactureRepository.GetFactures();
            cache.GetOrSet("ListeModelFactures", () => listeTouteFactures);

            //Mock et mise en cache commande
            CommandeRepository lCommandeRepository = new CommandeRepository();
            IList<Commande> listeTouteCommandes = lCommandeRepository.GetCommandes();
            cache.GetOrSet("ListeModelCommandes", () => listeTouteCommandes);

            //Mock et mise en cache client
            ClientRepository lClientRepository = new ClientRepository();
            IList<Client> listeTousClients = lClientRepository.GetClients(listeTouteFactures, listeTouteCommandes);
            cache.GetOrSet("ListeModelClient", () => listeTousClients);

        }

    }

}
