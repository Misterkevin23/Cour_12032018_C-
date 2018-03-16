using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Client
    {

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
        public List<Compte> compte;
        #endregion

        #region Constructeur
        public Client()
        {
            //compte = new Compte[5];
            compte = new List<Compte>();
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

            if (compte.Count() < 5)
            {
                compte.Add(unCompte);
                message = "Compte Ajouté";
            }
            else
            {
                message = "Les nombre de compte limite est atteint";
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
