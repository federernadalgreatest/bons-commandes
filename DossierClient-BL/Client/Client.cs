using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DossierClient_BL.Produits;
namespace DossierClient_BL.Client
{
    public class Client
    {
        private int _id;
        private string _name;
        private Dictionary<int,Logiciel> _logiciels;

        public Client(int id, string name, Dictionary<int, Logiciel> logiciels)
        {
            _id     = id;
            _name   = name;
            _logiciels = logiciels;
        }

        public Dictionary<int, Logiciel> ObtenirLogicielsClients()
        {
            return _logiciels;
        }

        public void AjouterLogiciel(Produit produit)
        {

        }
    }
}
