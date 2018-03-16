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
        public List <Compte> Comptes { get; set; }

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
            Comptes = new List<Compte>();
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
            if(Comptes.Count<5)
            {
                if (compte is CompteASeuil)
                {
                    ((CompteASeuil)compte).OnSeuil += DepassementSeuilHanldler;
                }
                Comptes.Add(compte);
                message = "Compte Ajouté";
            }
            else message = "Les nombre de compte limite a été atteint";
        }

        private void DepassementSeuilHanldler(object sender, EventArgs e)
        {
            Console.WriteLine("Dépassement de seuil");
        }

        public Compte GetCompte(int numCompte)
        {

            var c = Comptes.Where(x => x.Numero == numCompte).
                    FirstOrDefault();
            return c;
        }

        public override string ToString()
        {
            return string.Format("Je suis le client {0}, {1} et j'ai {2} comptes"
                , this.Prenom, this.Nom, this.Comptes.Count);
        }
        #endregion
    }
}
