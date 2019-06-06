using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibModel
{
    public class Facture : BaseObject
    {
        public int idFacture { get; set; }

        public int numFacture { get; set; }

        public int idClient { get; set; }
        
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dateFacture { get; set; }
    }
}
