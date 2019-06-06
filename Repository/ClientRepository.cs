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
        private static readonly int nbClient = 4;

        public IList<Client> GetClients(IList<Facture> listeTouteFactures, IList<Commande> listeTouteCommandes)
        {
            IList<Client> listeModel = new List<Client>();
            for (int i=0; i < nbClient; i++)
            {
                listeModel.Add(new Client()
                {
                    listeCommande = listeTouteCommandes.Where(n => n.idClient == i+1).ToList(),
                    listeFacture = listeTouteFactures.Where(n => n.idClient == i+1).ToList(),
                    idClient = i+1,
                    nomClient = $"Client {(i+1).ToString()}"
                });
            }
        
            return listeModel;

        }
    }
}
