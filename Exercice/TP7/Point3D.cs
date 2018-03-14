using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Point3D : Point2D
    {
        #region Constructeur
        public Point3D()
        {
        }

        public Point3D(int attX, int attY, int attZ) : base(attX, attY)
        {
            this.Z = attZ;
        }
        #endregion


        #region Properties
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        #endregion

        # region Methode
        public override string afficher()
        {
            //return ("[" + X + ", " + Y + ", "+ Z + "]");
            return (string.Format("Mon Point 3D a pour coordonnées:" + "[{0} , {1}, {2}]", this.X, this.Y, this.Z));
        }

        public void translater(int dX, int dY, int dZ)
        {
            base.translater(dX, dY);
            Z = Z + dZ;
        }
        #endregion
    }

}
