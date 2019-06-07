using LibModel;
using Repository;
using Repository.GestionCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestCoFact.Controllers
{
    public class ClientController : Controller
    {
        IList<Client> listeModelClients;
        ClientRepository repo;
        public ClientController()
        {
            repo = new ClientRepository();

            var cache = new InMemoryCache();
            listeModelClients = cache.GetOrSet("ListeModelClient", () => repo.GetClients());

        }

        public ActionResult Index()
        {
            return View(listeModelClients);
        }


        public ActionResult EditClient([Bind(Include = "Id,NomClient")] Client client)
        {
            if (ModelState.IsValid)
            {
                var cache = new InMemoryCache();

                cache.SetCache("cacheClient", client);

                return RedirectToAction("EditClient");
            }
            return View();
        }

        public ActionResult VisuClient([Bind(Include = "Id,NomClient")] Client client)
        {
            if (ModelState.IsValid)
            {
                var cache = new InMemoryCache();

                cache.SetCache("cacheClient", client);

                return RedirectToAction("VisuClient");
            }
            return View();
        }


    }


}