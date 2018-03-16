using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class CompteASeuil : Compte, ICompteASeuil
    {
        #region proprietie
        private double seuil;

        public double Seuil
        {
            get { return seuil; }
            set { seuil = value; }
        }


        #endregion

        #region Contructeur
        public CompteASeuil()
        {

        }

        public CompteASeuil(int numeros, double initialSolde, double taux) : base(numeros, initialSolde)
        {
            this.Seuil = seuil;
        }
        #endregion

        #region Methode

        public override string ToString()
        {
            return string.Format("Je suis  le compte à seuil numero {0}. Mon solde est de {1} et On ne peut plus retirer d'argent si le solde est inferieur à {2}", this.Numeros, this.Solde, this.Seuil);
        }

        public override void retirer(double uneValeur)
        {
            
            if ((this.Solde - uneValeur) >= this.Seuil)
            {
                this.Solde = this.Solde - uneValeur;
            }
            else
            {
                throw new BanqueException("Votre seuil est atteint");
            }
            
            
        }

        #endregion



    }
}
