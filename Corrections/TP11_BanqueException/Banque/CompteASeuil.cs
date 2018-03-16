using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
     class CompteASeuil : Compte, ICompteASeuil
    {
        
        public CompteASeuil(int unNumero, int unSoldeInitial = 0, double unSeuil=0)
            : base(unNumero, unSoldeInitial)
        {
            this.Seuil = unSeuil;
        }

        public double Seuil { get; private set; }

        public override void Retirer(double unMontant)
        {
            
            
                if ((Solde - unMontant) >= Seuil)
                {
                    base.Retirer(unMontant);
                }
                else
                {
                    string message = string.Format(
                        "Le compte N° {0} a tenté de sortir de son seuil autorisé de {1}",
                        this.Numero, this.Seuil);
                    throw new BanqueException(message);
                }
            
        }

        public override string ToString()
        {
            return "Compte à Seuil - "+ base.ToString();
        }
    }
}
