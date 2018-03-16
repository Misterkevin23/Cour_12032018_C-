using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    interface ICompteASeuil
    {
        void retirer(double uneValeur);
     
        double Seuil
        {
            get;
            set;
        }

        //double getSeuil();
        //void setSeuil(double unSeuil);
    }
}
