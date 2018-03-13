using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Time
    {
        int hour, minutes;

        public int Afficher()
        {
            hour = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;

            return hour * 60 + minutes;
        }

        public int Afficher (string horaire)
        {
            string[] time = horaire.Split(':');
            hour = 0;
            minutes = 0;
            int.TryParse(time[0], out hour);
            int.TryParse(time[1], out minutes);
            return hour * 60 + minutes;
        }

    }
}
