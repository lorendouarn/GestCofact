using LibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FactureRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Facture> GetFactures()
        {
            IList<Facture> listeModel = new List<Facture>();

            listeModel.Add(new Facture()
            {
                idFacture=1,
                numFacture=101,
                idClient=1,
                dateFacture = DateTime.Now
            });

            listeModel.Add(new Facture()
            {
                idFacture = 2,
                numFacture = 102,
                idClient = 1,
                dateFacture = DateTime.Now
            });

            listeModel.Add(new Facture()
            {
                idFacture = 3,
                numFacture = 103,
                idClient = 1,
                dateFacture = DateTime.Now
            });

            listeModel.Add(new Facture()
            {
                idFacture = 4,
                numFacture = 104,
                idClient = 2,
                dateFacture = DateTime.Now
            });

            listeModel.Add(new Facture()
            {
                idFacture = 5,
                numFacture = 105,
                idClient = 3,
                dateFacture = DateTime.Now
            });

            listeModel.Add(new Facture()
            {
                idFacture = 6,
                numFacture = 106,
                idClient = 3,
                dateFacture = DateTime.Now
            });

            return listeModel;

        }

    }
}
