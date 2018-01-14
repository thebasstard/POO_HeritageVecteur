using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Vecteur
{
    class Program
    {
        static void Main(string[] args)
        {
            Vecteurs2D v2d1 = new Vecteurs2D(1,2);
            Vecteurs2D v2d2 = new Vecteurs2D(1,2);
            Vecteurs3D v3d1 = new Vecteurs3D(5,8,8);
            Vecteurs3D v3d2 = new Vecteurs3D(5,7,8);

            Console.Out.WriteLine("1 2d : la norme est : " + v2d1.Norme());
            Console.Out.WriteLine("2 2d : la norme est : " + v2d2.Norme());
            Console.Out.WriteLine("1 3d : la norme est : " + v3d1.Norme());
            Console.Out.WriteLine("2 3d : la norme est : " + v3d2.Norme());


            if (v2d1.Equals(v2d2))
            {
                Console.Out.WriteLine("2d :Les deux objets sont identiques");
            }
            else
            {
                Console.Out.WriteLine("2d :Ils ne sont pas identiques");
            }

            if (v3d1.Equals(v3d2))
            {
                Console.Out.WriteLine(" 3d :Les deux objets sont identiques");
            }
            else
            {
                Console.Out.WriteLine("3d :Ils ne sont pas identiques");
            }

            Console.Out.WriteLine("Le nombre de vecteurs crées est: " + Vecteurs2D.Nombre);
        

            Console.ReadKey();
        }
    }
}
