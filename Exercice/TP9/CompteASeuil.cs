﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class CompteASeuil : Compte
    {
        #region proprietie
        public double taux;

        #endregion

        #region Contructeur
        public CompteASeuil()
        {

        }

        public CompteASeuil(int numeros, double initialSolde, double taux) : base(numeros, initialSolde)
        {
            this.taux = taux;
        }
        #endregion

        #region Methode

        public override string ToString()
        {
            return string.Format("Je suis  le compte à seuil numero {0}. Mon solde est de {1} et On ne peut plus retirer d'argent si le solde est inferieur à {2}", this.Numeros, this.Solde, this.taux);
        }

        public override void retirer(double uneValeur)
        {
            if( (this.Solde- uneValeur) >= this.taux)
            {
                this.Solde = this.Solde - uneValeur;
            }
        }

        #endregion


    }
}
