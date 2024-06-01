using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DossierClient_BL.Client;
using DossierClient_BL.Factures;
using DossierClient_BL.Produits;

namespace DossierClient_BL.Bons
{
    public class BonDeCommande
    {
        private int _id;
        private DossierClient_BL.Client.Client _client;

        private Dictionary<int,LigneBonDeCommande> _lignes;
        private Dictionary<int,IPrixCalculable> _lignesCalculables;
        private CalculateurPrix _calculateur;

        public DateTime DateCree { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string Responsable { get; set; }
        public string CreerPar { get; set; }

        public BonDeCommande(DossierClient_BL.Client.Client client)
        {
            AttribuerClient(client);
            _lignes          = new Dictionary<int,LigneBonDeCommande>();
            _lignesCalculables = new Dictionary<int, IPrixCalculable>();
            _calculateur     = new CalculateurPrix(client.ObtenirLogicielsClients(), _lignesCalculables);
        }

        public BonDeCommande(int idBonCommande,DossierClient_BL.Client.Client client,Dictionary<int,LigneBonDeCommande> lignesBonCommande)
        {
            _id = idBonCommande;
            AttribuerClient(client);
            _lignes = lignesBonCommande;
            _lignesCalculables = new Dictionary<int, IPrixCalculable>();
        }


        public void AttribuerClient(DossierClient_BL.Client.Client client)
        {
            if(_lignes.Count > 0)
            {
                // Recalcul
            }
            else
            {

            }
        }

        public void AjouterProduit(List<Produit> produit, int quantite) 
        {

            // foreach Produit
            // new LigneBonCommande(Produit)
            //_lignesCalculables[pIdProduit] = _lignes[pIdProduit];

            //calculateur.CalculerPrix(produit)
        }

        public void ChangerQuantiteProduit(int pIdProduit, int quantite)
        {
            //lignes[pIdProduit].Quantite = quantite

            //calculateur.CalculerPrix(lignes[pIdProduit].Produit)
        }

        public void RetirerProduit(int pIdProduit)
        {

        }

        public decimal ObtenirSousTotal()
        {
            //_calculateur.CalculerSousTotal()
            return 1.0m;
        }

        public decimal ObtenirTotal()
        {
            //_calculateur.CalculerTotal()
            return 1.0m;
        }

        public List<LigneBonDeCommandeModel> ObtenirLignesBons()
        {
            return _lignes.Select(l => l.Value.VersModel()).ToList();
        }
    }
}
