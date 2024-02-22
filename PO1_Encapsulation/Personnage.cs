using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        string nom;
        int pointDevie;
        int pointDePuissance;


        public string Nom { get => nom; set => nom = value; }
        public int PointDevie { get => pointDevie;
            set 
            {
                if(value < 0)
                {
                    pointDevie = 0;
                }
                else
                {
                    pointDevie = value;
                }
            }
        }
        public int PointDePuissance { get => pointDePuissance; set => pointDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if(pointDevie > 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
