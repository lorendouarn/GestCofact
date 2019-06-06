using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibModel
{
    public class Commande: BaseObject
    {
        public int idCommande { get; set; }

        public int idClient { get; set; }

        public string description { get; set; }

        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dateCommande { get; set; }

    }
}
