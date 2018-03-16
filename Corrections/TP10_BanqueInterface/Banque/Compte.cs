using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Compte
    {
        public double Solde { get; protected set; }
        public int Numero { get; protected set; }

        #region Constructors
        public Compte() : this(0,0)
        {
            
        }

        public Compte(int unNumero, double unSolde)
        {
            Numero = unNumero;
            Solde = unSolde;
        }
        #endregion

        #region Methodes
        public virtual void Ajouter(double unMontant)
        {
            Solde += unMontant;
        }

        public virtual void Retirer (double unMontant)
        {
            Solde -= unMontant;
        }

        public override string ToString()
        {
            return string.Format("Je suis le Compte N° {0} avec le solde {1}",
                this.Numero, this.Solde);
        }
        #endregion
    }
}
