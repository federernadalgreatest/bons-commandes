using DossierClient_BL.Factures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DossierClient_BL.Produits
{
    public class Produit
    {
        private int         _id;
        private string      _name;
        private string      _description;
        private bool        _estMaitre;
        private bool        _estContrat;
        private decimal     _prixUnitaire;
        private int         _idProduitLie;
        private EchellePrix     _echelleDePrixContrat;

        public Produit(int id, string name, string description, bool estMaitre, bool estContrat, decimal prixUnitaire, int idProduitLie, EchellePrix echelleDePrixContrat)
        {
            _id = id;
            _name = name;
            _description = description;
            _estMaitre = estMaitre;
            _estContrat = estContrat;
            _prixUnitaire = prixUnitaire;
            _idProduitLie = idProduitLie;
            _echelleDePrixContrat = echelleDePrixContrat;
        }

        // Méthodes d'accès aux attributs
        public int Id()
        {
            return _id;
        }

        public string Name()
        {
            return _name;
        }

        public string Description()
        {
            return _description;
        }

        public bool EstMaitre()
        {
            return _estMaitre;
        }

        public bool EstContrat()
        {
            return _estContrat;
        }

        public decimal PrixUnitaire()
        {
            return _prixUnitaire;
        }

        public int IdProduitLie()
        {
            return _idProduitLie;
        }

        public EchellePrix EchelleDePrixContrat()
        {
            return _echelleDePrixContrat;
        }
    }
}

