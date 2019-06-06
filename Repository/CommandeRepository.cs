using LibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommandeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Commande> GetCommandes()
        {
            IList<Commande> listeModel = new List<Commande>();

            listeModel.Add(new Commande()
            {
                idCommande = 1,
                idClient = 1,
                description = "Commande id 1 du client 1",
                dateCommande = DateTime.Now
            });

            listeModel.Add(new Commande()
            {
                idCommande = 2,
                idClient = 1,
                description = "Commande id 2 du client 1",
                dateCommande = DateTime.Now
            });

            listeModel.Add(new Commande()
            {
                idCommande = 3,
                idClient = 1,
                description = "Commande id 3 du client 1",
                dateCommande = DateTime.Now
            });

            listeModel.Add(new Commande()
            {
                idCommande = 4,
                idClient = 2,
                description = "Commande id 4 du client 2",
                dateCommande = DateTime.Now
            });

            listeModel.Add(new Commande()
            {
                idCommande = 5,
                idClient = 3,
                description = "Commande id 5 du client 3",
                dateCommande = DateTime.Now
            });

            listeModel.Add(new Commande()
            {
                idCommande = 6,
                idClient = 3,
                description = "Commande id 6 du client 3",
                dateCommande = DateTime.Now
            });


            return listeModel;

        }

    }
}
