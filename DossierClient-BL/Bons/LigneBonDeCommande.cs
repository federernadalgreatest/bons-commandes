using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DossierClient_BL.Factures;
using DossierClient_BL.Produits;

namespace DossierClient_BL.Bons
{
    public class LigneBonDeCommande: IPrixCalculable
    {
        private int _id;
        private int _idBon;
        public Produit Produit { get; set; }

        public int Quantite { get; set; }
        public decimal PrixUnitaire{ get; set; }

        public decimal Prix { get; set; }

        public LigneBonDeCommande(Produit produit, int id, int idBon, int quantite, decimal prixUnitaire, decimal prix)
        {
            Produit = produit;
            Quantite = quantite;
            PrixUnitaire = prixUnitaire;
            Prix = prix;
            _id = id;
            _idBon = idBon;
        }

        public LigneBonDeCommandeModel VersModel()
        {
            return new LigneBonDeCommandeModel();
        }
    }
}
