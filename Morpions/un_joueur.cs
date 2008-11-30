using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Morpions
{
    public partial class un_joueur : Form
    {
        int[,] tab = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int niveau = 0;
        int joueur = 0;
        int joueur2 = 1;

        public void ia(int[,] tab, int lvl) {
            bool tmp;
            if (lvl == 1) {
                bool ok = false;
                while (!ok) {
                    Random rndNumbers_x = new Random();
                    int rndNumber_x = 0;
                    rndNumber_x = rndNumbers_x.Next(3);
                   

                    Random rndNumbers_y = new Random();
                    int rndNumber_y = 0;
                    rndNumber_y = rndNumbers_y.Next(3);
                    

                    if (tab[rndNumber_x, rndNumber_y] == 0) {
                        tab[rndNumber_x, rndNumber_y] = 2;
                        ok = true;
                    }
                }
            }
            else if (lvl == 2)
            {

            }
            else { 
            
            }
            if (tab[0, 0] == 2)
            {
                morpion_1_1.Text = "O";
                morpion_1_1.Update();
            }
            if (tab[0, 1] == 2)
            {
                morpion_1_2.Text = "O";
                morpion_1_2.Update();
            }
            if (tab[0, 2] == 2)
            {
                morpion_1_3.Text = "O";
                morpion_1_3.Update();
            }
            if (tab[1, 0] == 2)
            {
                morpion_2_1.Text = "O";
                morpion_2_1.Update();
            }
            if (tab[1, 1] == 2)
            {
                morpion_2_2.Text = "O";
                morpion_2_2.Update();
            }
            if (tab[1, 2] == 2)
            {
                morpion_2_3.Text = "O";
                morpion_2_3.Update();
            }
            if (tab[2, 0] == 2)
            {
                morpion_3_1.Text = "O";
                morpion_3_1.Update();
            }
            if (tab[2, 1] == 2)
            {
                morpion_3_2.Text = "O";
                morpion_3_2.Update();
            }
            if (tab[2, 2] == 2)
            {
                morpion_3_3.Text = "O";
                morpion_3_3.Update();
            }
            tmp = routine_victoire(tab);
        } 

        public bool routine_victoire(int[,] tab) {
            bool victory = false;
            int win = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                if (tab[i, 0] == tab[i, 1] && tab[i, 0] == tab[i, 2] && tab[i, 0]!=0)
                {
                    victory = true;
                    win = tab[i, 0];
                }
                if (tab[0, i] == tab[1, i] && tab[0, i] == tab[2, i] && tab[0,i] != 0)
                {
                    victory = true;
                    win = tab[0, i];
                }
            }

            if (tab[0, 0] == tab[1, 1] && tab[0, 0] == tab[2, 2] && tab[0, 0] != 0)
            {
                victory = true;
                win = tab[0, 0];
            }

            if (tab[0, 2] == tab[1, 1] && tab[0, 2] == tab[2, 0] && tab[0, 2] != 0)
            {
                victory = true;
                win = tab[0, 2]; 
            }


            if (victory)
            {
                if (win == 1)
                {
                    label_morpions.Text = "Victory";
                    return true;
                }
                else {
                    label_morpions.Text = "Lost";
                    return true;
                }
            }
            return false;
        }

        public un_joueur()
        {
        }

        public un_joueur(int lvl) {
            InitializeComponent();
            niveau = lvl;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur.ActiveForm.Close();
        }

        private void morpion_1_1_Click(object sender, EventArgs e)
        {
            if (tab[0, 0] == 0)
            {
                morpion_1_1.Text = "X";
                morpion_1_1.Update();
                tab[0, 0] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_1_2_Click(object sender, EventArgs e)
        {
            if (tab[0, 1] == 0)
            {
                morpion_1_2.Text = "X";
                morpion_1_2.Update();
                tab[0, 1] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_1_3_Click(object sender, EventArgs e)
        {
            if (tab[0, 2] == 0)
            {
                morpion_1_3.Text = "X";
                morpion_1_3.Update();
                tab[0, 2] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_2_1_Click(object sender, EventArgs e)
        {
            if (tab[1, 0] == 0)
            {
                morpion_2_1.Text = "X";
                morpion_2_1.Update();
                tab[1, 0] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_2_2_Click(object sender, EventArgs e)
        {
            if (tab[1, 1] == 0)
            {
                morpion_2_2.Text = "X";
                morpion_2_2.Update();
                tab[1, 1] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_2_3_Click(object sender, EventArgs e)
        {
            if (tab[1, 2] == 0)
            {
                morpion_2_3.Text = "X";
                morpion_2_3.Update();
                tab[1, 2] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_3_1_Click(object sender, EventArgs e)
        {
            if (tab[2, 0] == 0)
            {
                morpion_3_1.Text = "X";
                morpion_3_1.Update();
                tab[2, 0] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_3_2_Click(object sender, EventArgs e)
        {
            if (tab[2, 1] == 0)
            {
                morpion_3_2.Text = "X";
                morpion_3_2.Update();
                tab[2, 1] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void morpion_3_3_Click(object sender, EventArgs e)
        {
            if (tab[2, 2] == 0)
            {
                morpion_3_3.Text = "X";
                morpion_3_3.Update();
                tab[2, 2] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

    }
}
