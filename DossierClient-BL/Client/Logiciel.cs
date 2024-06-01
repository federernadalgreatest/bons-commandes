using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DossierClient_BL.Client
{
    public class Logiciel
    {
        private int _id;
        private string _name;
        private int _idProduit;
        private int _nbLicences;
        // private DateTime _dateDebutSupport;
        // private DateTime _dateFinSupport;

        public Logiciel(int id, string name, int idProduit, int nbLicences)
        {
            _id         = id;
            _name       = name;
            _idProduit  = idProduit;
            _nbLicences = nbLicences;
        }

        public int NombreDeLicencces()
        {
            return _nbLicences;
        }

        public void AjouterLicence(int nbLicences)
        {

        }

        public void RetirerLicence(int nbLicences)
        {

        }
    }
}
