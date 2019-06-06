using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibModel
{
    public class Client:BaseObject
    {
        public IList<Commande> listeCommande;
        public IList<Facture> listeFacture;

        public int idClient { get; set; }

        [Required, StringLength(50, MinimumLength = 10)]
        public string nomClient { get; set; }

    }

}
