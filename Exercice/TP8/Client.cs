using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        private int age;


        private DateTime dob;

        public DateTime DOB 
        {
            get { return dob; }
            set { dob = value; }
        }

        public int Numero { get; set; }
        Compte[] compte= new Compte[5];

        public void ajouterCompte(Compte unCompte)
        {

        }

    }
}
