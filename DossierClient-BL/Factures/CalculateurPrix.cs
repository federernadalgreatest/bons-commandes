using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DossierClient_BL.Bons;
using DossierClient_BL.Client;
using DossierClient_BL.Produits;

namespace DossierClient_BL.Factures
{
    internal class CalculateurPrix
    {
        private Dictionary<int,Logiciel>            _logicielsClient;
        private Dictionary<int, IPrixCalculable>    _calculables;

        public CalculateurPrix(Dictionary<int, Logiciel> logicielsClient, Dictionary<int, IPrixCalculable> calculables)
        {
            _logicielsClient    = logicielsClient;
            _calculables        = calculables;
        }

        public void CalculerPrix(Produit produit)
        {
            // SI produit.estProduitMaitre ALORS
            //  CalculerPrixProduitMaitre(produit.id)
            // SI produit.estProduitKit ALORS
            //  CalculerPrixProduitKit(produit.id)
            // SI PAS produit.estProduitMaitre && PAS produit.estProduitKit ALORS
            //  CalculerPrixProduit(produit.id)
        }
        public void CalculerSousTotal()
        {

        }
        public void CalculerTotal()
        {

        }

        private void CalculerPrixProduitMaitre(int idProduit)
        {
           
        }

        private void CalculerPrixProduit(int idProduit)
        {

        }

        private void CalculerPrixProduitKit(int idProduit) 
        {

        }
    }
}
