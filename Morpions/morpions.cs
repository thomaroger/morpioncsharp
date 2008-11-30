using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morpions
{
    public class morpions
    {
        int id_joueur;

        public int Id_joueur
        {
            get { return id_joueur; }
            set { id_joueur = value; }
        }
        int id_joueur2;

        public int Id_joueur2
        {
            get { return id_joueur2; }
            set { id_joueur2 = value; }
        }
        int lvl;

        public int Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }

        
        public morpions() { }
        public morpions(int joueur1, int joueur2, int lvl) {
            Id_joueur = joueur1;
            Id_joueur2 = joueur2;
            Lvl = lvl;
        }
    }
}
