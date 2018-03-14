using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class Client
    {
        #region Constructeur
        public Client()
        {
            compte = new Compte[5];
        }

        public Client(string nom, string prenom, DateTime dob, int numero)
             : this()
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DOB = dob;
            this.Numero = numero;
        }

        #endregion


        #region propriety
        public string Nom { get; set; }
        public string Prenom { get; set; }


        private DateTime dob;

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int Numero { get; private set; }
        Compte[] compte;
        #endregion


        #region Methode
        public int getAge()
        {
            TimeSpan diffTemps = DateTime.Now - DOB;
            int annees = diffTemps.Days / 365;
            return annees;
            //Console.WriteLine(annees);
        }

        public void ajouterCompte(Compte unCompte, out string message)
        {
            message = "";

            for (int i = 0; i <= compte.Length; i++)
            {

                if (i == compte.Length)
                {
                    message = "Les nombre de compte limite est atteint";
                    break;
                }
                if (compte[i] == null)
                {
                    compte[i] = unCompte;
                    break;
                }
            }

        }

        public Compte getCompte(int numeroCompte)
        {
            foreach (Compte c in compte)
            {
                if (c != null && c.Numeros == numeroCompte) //il faut verifier que le tableau
                {
                    return c;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
