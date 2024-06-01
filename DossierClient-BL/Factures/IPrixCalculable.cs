using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DossierClient_BL.Factures
{
    internal interface IPrixCalculable
    {
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }

        public decimal Prix { get; set; }
    }
}
