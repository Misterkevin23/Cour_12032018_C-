using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Client
    {
        #region Properties
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DOB { get; set; }
        public int NumClient { get; private set; }
        public Compte[] Comptes { get; set; }

        public int Age
        {
            get
            {
                return(DateTime.Now - DOB).Days / 365;
            }
        }


        #endregion

        #region Constructors
        public Client()
        {
            Comptes = new Compte[5];
        }

        public Client(string nom, string prenom, DateTime dob, int numero)
            :this()
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DOB = dob;
            this.NumClient = numero;
        }
        #endregion

        #region Methodes
        public void AjouterCompte(Compte compte, out string message)
        {
            message = "";
            for (int i = 0; i <= Comptes.Length; i++)
            {
                if (i==Comptes.Length)
                {
                    message = "Les nombre de compte limite a été atteint";
                    break;
                }
                if (Comptes[i]==null)
                {
                    Comptes[i] = compte;
                    message = "Compte Ajouté";
                    break;
                }
            }
        }

        public Compte GetCompte(int numCompte)
        {

            foreach (Compte c in Comptes)
            {
                if (c!=null && c.Numero==numCompte)
                {
                    return c;
                }
                
            }
            return null;
        }

        public override string ToString()
        {
            return string.Format("Je suis le client {0}, {1} et j'ai {2} ans"
                , this.Prenom, this.Nom, this.Age);
        }
        #endregion
    }
}
