using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class CompteRemunere : Compte, ICompteRemunere
    {

        #region Contructeur
        public CompteRemunere()
        {

        }

        public CompteRemunere(int numeros, double initialSolde, double taux) : base(numeros, initialSolde)
        {
            this.Taux = taux;
        }
        #endregion

        #region proprietie
        private double taux;

        public double Taux
        {
            get { return taux; }
            set
            {
                if (taux >= 0 && taux <= 1)
                {
                    taux = value;
                }
                else
                {
                    taux = 0.1;
                }

            }
        }
        #endregion

        #region Methode
        public override string ToString()
        {
            return string.Format("Je suis  le compte rémunéré numero {0}. Mon solde est de {1} et mon taux est de {2}", this.Numeros, this.Solde, this.Taux);
        }

        public double calculerInterets()
        {
            return this.Taux * this.Solde;
        }

        public void verserInterets()
        {
            this.Solde += this.calculerInterets();
        }
        #endregion

    }
}
