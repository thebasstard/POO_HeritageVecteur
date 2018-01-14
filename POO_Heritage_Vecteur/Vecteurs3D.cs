using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Vecteur
{
    class Vecteurs3D : Vecteurs2D
    {
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vecteurs3D() : base() { }

        public Vecteurs3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public Vecteurs3D(Vecteurs3D v) : base(v.Abscisse, v.Ordonnee)
        {
            this.z = v.z;
        }

        public override string ToString()
        {
            return "z = " + z;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if(obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Vecteurs3D v = (Vecteurs3D)obj;
                if (this.Abscisse == v.Abscisse && this.Ordonnee == v.Ordonnee && this.Z == v.Z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        
        }

        public override double Norme()
        {
            return Math.Sqrt(Abscisse * Abscisse + Ordonnee * Ordonnee + z * z);
        }

    }
}
