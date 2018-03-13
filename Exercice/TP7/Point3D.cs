using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Point3D : Point2D
    {
        int attZ;

        public Point3D()
        {
        }

        public Point3D(int attX, int attY, int attZ) : base(attX, attY)
        {
            this.Z = attZ;
        }

        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public override string afficher()
        {
            return ("[" + X + ", " + Y + ", "+ Z + "]");
        }

        public void translater(int dX, int dY, int dZ)
        {
            X = X + dX;
            Y = Y + dY;
            Z = Z + dZ;
        }

    }

}
