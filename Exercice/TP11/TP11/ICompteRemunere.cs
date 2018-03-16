using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    interface ICompteRemunere
    {
        double calculerInterets();
        void verserInterets();
        double Taux
        {
            get;
            set;
        }
  
        //double getTaux();
        //void setTaux(double unTaux);
    }
}
