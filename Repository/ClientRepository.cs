using LibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientRepository
    {
        public IList<Client> GetClients()
        {
            IList<Commande> listeTouteCommandes = new CommandeRepository().GetCommandes();
            IList<Facture> listeTouteFactures = new FactureRepository().GetFactures();
            IList<Client> listeModel = new List<Client>();
            for (int i=1; i < 5; i++)
            {
                listeModel.Add(new Client()
                {
                    listeCommande = listeTouteCommandes.Where(n => n.idClient == i).ToList(),
                    listeFacture = listeTouteFactures.Where(n => n.idClient == i).ToList(),
                    idClient = i,
                    nomClient = $"Client {i.ToString()}"
                });
            }
        
            return listeModel;

        }
    }
}
