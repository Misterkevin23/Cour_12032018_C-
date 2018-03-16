using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Compte
    {

        #region propretie
        private int numeros;

        public int Numeros
        {
            get { return numeros; }
            private set { numeros = value; }
        }

        private double solde;



        public double Solde
        {
            get { return solde; }
            protected set { solde = value; }
        }

        public void ajouter(double unMontant)
        {
            Solde += unMontant;
        }
        #endregion

        #region Constructeur
        public Compte() : this(0, 0)
        {
        }

        public Compte(int numeros, double initialSolde)
        {
            this.Numeros = numeros;
            this.Solde = initialSolde;
        }
        #endregion

        #region Methode
        public virtual void retirer(double unMontant)
        {
            Solde -= unMontant;
        }


        public override string ToString()
        {
            return string.Format("Je suis  le compte numero {0}. Mon solde est de {1}", this.Numeros, this.Solde);
        }
        #endregion

    }
}
