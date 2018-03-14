using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP05_Classe
{
     class Point3D : Point2D
    {
        #region Properties
        public int Z
        {
            get ;
            private set;
            
        }
        #endregion

        #region Methodes
        public void Translater(int dx, int dy, int dz)
        {
            base.Translater(dx, dy);
            this.Z += dz;
        }

        public override string Afficher()
        {
            return (string.Format("Monn POint 3D a pour ccordonnées :" +
                "[{0}, {1}, {2}]", this.X, this.Y, this.Z));
        }

        #endregion

        #region Constructors
            public Point3D() : base() {
            this.Z = 0;
        }

        public Point3D(int dx, int dy, int dz) : base(dx, dy)
        {
            this.Z = dz;
        }
        #endregion
    }
}