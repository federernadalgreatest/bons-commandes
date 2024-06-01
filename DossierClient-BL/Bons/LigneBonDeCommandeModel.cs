using DossierClient_BL.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DossierClient_BL.Bons
{
    public class LigneBonDeCommandeModel
    {
        public Produit Produit { get;}

        public int Quantite { get;}
        public decimal PrixUnitaire { get;}

        public decimal Prix { get;}
    }
}
