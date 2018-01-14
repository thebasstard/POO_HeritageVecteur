using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Vecteur
{
    class Vecteurs2D
    {
        private double abscisse;
        private double ordonnee;
        private static int nombre = 0;



        public double Abscisse
        {
            get { return abscisse; }
            set { abscisse = value; }
        }

        public double Ordonnee
        {
            get { return ordonnee; }
            set { ordonnee = value; }
        }

        public static int Nombre
        {
            get { return nombre; }
            //set { nombre = value; }
        }

        public Vecteurs2D() { nombre++; }

        public Vecteurs2D(double x, double y)
        {
            nombre++;
            abscisse = x;
            ordonnee = y;
        }

        public Vecteurs2D(Vecteurs2D v)
        {
            nombre++;
            abscisse = v.abscisse;
            ordonnee = v.ordonnee;
        }

        public override string ToString()
        {
            return "x = " + abscisse + ", y = " + ordonnee;
        }

        

        public override bool Equals(object obj)
        {
            if (obj == null)                               //Comparer à null
                return false;
            else if (obj == this)                          //Comparer à lui même
                return true;
            else if (obj.GetType() != this.GetType())      //Deux types incomparables
                return false;
            else
            {
                Vecteurs2D v = (Vecteurs2D)obj;              //Convertir l'objet en vecteur
                if (this.abscisse == v.abscisse && this.ordonnee == v.ordonnee)        //Comparer le contenu
                    return true;
                else
                    return false;
            }
        }

        public virtual double Norme()
        {
            return Math.Sqrt(abscisse * abscisse + ordonnee * ordonnee);
        }

    }


}
