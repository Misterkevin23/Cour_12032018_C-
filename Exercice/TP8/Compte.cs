using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Compte
    {

        public Compte()
        {
        }

        private int numeros;

        public int Numeros
        {
            get { return numeros; }
            set { numeros = value; }
        }

        private double solde;

       

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public void ajouter(double unMontant)
        {
            Solde += unMontant;
        }

        public void retirer(double unMontant)
        {
            Solde -= unMontant;
        }


    }
}
