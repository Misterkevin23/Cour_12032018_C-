using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class CompteASeuilRemunere : CompteRemunere, ICompteASeuil
    {
        #region proprety
        private double seuil;

        public double Seuil
        {
            get { return seuil; }
            set { seuil = value; }
        }
        #endregion

        #region Constructeur
        public CompteASeuilRemunere()
        {
        }

        public CompteASeuilRemunere(int numeros, double initialSolde, double taux, double seuil) : base(numeros, initialSolde, taux)
        {
            this.Seuil = seuil;
        }
        #endregion

        #region Methode
        public override string ToString()
        {
            return string.Format("Je suis  le compte à seuil rémunéré numero {0}. Mon solde est de {1} et mon taux est de {2} et mon seuil est {3}", this.Numeros, this.Solde, this.Taux, this.Seuil);
        }

        #endregion

    }
}
