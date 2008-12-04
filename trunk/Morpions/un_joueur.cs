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
            bool tmp,faire=false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tab[j, i] == 0)
                        faire = true;
                }
            }
            if (faire)
            {
                if (lvl == 1)
                {
                    // Niveau Noobs
                    bool ok = false;
                    while (!ok)
                    {
                        Random rndNumbers_x = new Random();
                        int rndNumber_x = 0;
                        rndNumber_x = rndNumbers_x.Next(3);


                        Random rndNumbers_y = new Random();
                        int rndNumber_y = 0;
                        rndNumber_y = rndNumbers_y.Next(3);


                        if (tab[rndNumber_x, rndNumber_y] == 0)
                        {
                            tab[rndNumber_x, rndNumber_y] = 2;
                            ok = true;
                        }
                    }
                }
                else if (lvl == 2)
                {
                    // Niveau RoXor
                    Boolean joue = false;
                    if (tab[0, 0] == tab[0, 1] && tab[0, 0] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[0, 2] && tab[0, 0] == 1 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[0, 1] && tab[0, 2] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[1, 1] == tab[1, 1] && tab[1, 0] == 1 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[1, 0] == tab[1, 2] && tab[1, 0] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 2] == tab[1, 1] && tab[1, 2] == 1 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }


                    if (tab[2, 0] == tab[2, 1] && tab[2, 0] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[2, 2] && tab[2, 0] == 1 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[2, 1] && tab[2, 2] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 0] == tab[1, 0] && tab[0, 0] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 0] && tab[0, 0] == 1 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 0] && tab[2, 0] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 1] == tab[1, 1] && tab[0, 1] == 1 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 1] == tab[2, 1] && tab[0, 1] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 1] == tab[1, 1] && tab[2, 1] == 1 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[1, 2] && tab[0, 2] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 2] && tab[0, 2] == 1 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[1, 2] && tab[2, 2] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    
                    if (tab[0, 0] == tab[1, 1] && tab[1, 1] == 1 && tab[2, 2] == 0 && joue == false) {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 2] && tab[2, 2] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 1] == tab[2, 2] && tab[2, 2] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 2] == tab[1, 1] && tab[1, 1] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 0] && tab[2, 0] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 1] && tab[1, 1] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }


                    if ((tab[0, 0] == 1 || tab[2, 2] == 1 || tab[0, 2] == 1 || tab[2, 0] == 1) && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    Console.WriteLine(joue);
                    if (!joue)
                    {
                        bool ok = false;
                        while (!ok)
                        {
                            Random rndNumbers_x = new Random();
                            int rndNumber_x = 0;
                            rndNumber_x = rndNumbers_x.Next(3);


                            Random rndNumbers_y = new Random();
                            int rndNumber_y = 0;
                            rndNumber_y = rndNumbers_y.Next(3);


                            if (tab[rndNumber_x, rndNumber_y] == 0)
                            {
                                tab[rndNumber_x, rndNumber_y] = 2;
                                ok = true;
                            }
                        }
                    }
                }
                else
                {
                    Boolean joue = false;
                    
                    if (tab[0, 0] == tab[0, 1] && tab[0, 0] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 2] && tab[0, 0] == 1 && tab[1, 1] == 2 && tab[0, 2]==0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[0, 2] && tab[2, 0] == 1 && tab[1, 1] == 2 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }

                    //Attaque
                    if (tab[0, 0] == tab[0, 2] && tab[0, 0] == 2 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[0, 1] && tab[0, 2] == 2 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[1, 1] == tab[1, 1] && tab[1, 0] == 2 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[1, 0] == tab[1, 2] && tab[1, 0] == 2 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 2] == tab[1, 1] && tab[1, 2] == 2 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }


                    if (tab[2, 0] == tab[2, 1] && tab[2, 0] == 2 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[2, 2] && tab[2, 0] == 2 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[2, 1] && tab[2, 2] == 2 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 0] == tab[1, 0] && tab[0, 0] == 2 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 0] && tab[0, 0] == 2 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 0] && tab[2, 0] == 2 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 1] == tab[1, 1] && tab[0, 1] == 2 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 1] == tab[2, 1] && tab[0, 1] == 2 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 1] == tab[1, 1] && tab[2, 1] == 2 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[1, 2] && tab[0, 2] == 2 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 2] && tab[0, 2] == 2 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[1, 2] && tab[2, 2] == 2 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }


                    if (tab[0, 0] == tab[1, 1] && tab[1, 1] == 2 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 2] && tab[2, 2] == 2 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 1] == tab[2, 2] && tab[2, 2] == 2 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 2] == tab[1, 1] && tab[1, 1] == 2 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 0] && tab[2, 0] == 2 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 1] && tab[1, 1] == 2 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }



                    // Defense

                    if( tab[0,0] == tab[2, 1] && tab[0, 0] == 1 && tab[2, 0] == 0 && joue == false){
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 2] && tab[2, 0] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[0, 1] && tab[0, 1] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[1, 0] && tab[1, 0] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }



                    if (tab[0, 0] == tab[0, 2] && tab[0, 0] == 1 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[0, 1] && tab[0, 2] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[1, 1] == tab[1, 1] && tab[1, 0] == 1 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[1, 0] == tab[1, 2] && tab[1, 0] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 2] == tab[1, 1] && tab[1, 2] == 1 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }


                    if (tab[2, 0] == tab[2, 1] && tab[2, 0] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[2, 2] && tab[2, 0] == 1 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[2, 1] && tab[2, 2] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 0] == tab[1, 0] && tab[0, 0] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 0] && tab[0, 0] == 1 && tab[1, 0] == 0 && joue == false)
                    {
                        tab[1, 0] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 0] && tab[2, 0] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 1] == tab[1, 1] && tab[0, 1] == 1 && tab[2, 1] == 0 && joue == false)
                    {
                        tab[2, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 1] == tab[2, 1] && tab[0, 1] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 1] == tab[1, 1] && tab[2, 1] == 1 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[1, 2] && tab[0, 2] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 2] && tab[0, 2] == 1 && tab[1, 2] == 0 && joue == false)
                    {
                        tab[1, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 2] == tab[1, 2] && tab[2, 2] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }


                    if (tab[0, 0] == tab[1, 1] && tab[1, 1] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[2, 2] && tab[2, 2] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 1] == tab[2, 2] && tab[2, 2] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }


                    if (tab[0, 2] == tab[1, 1] && tab[1, 1] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 0] && tab[2, 0] == 1 && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[1, 1] && tab[1, 1] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }


                    if ((tab[0, 0] == 1 || tab[2, 2] == 1 || tab[0, 2] == 1 || tab[2, 0] == 1) && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    
                    if (!joue)
                    {
                        bool ok = false;
                        while (!ok)
                        {
                            Console.WriteLine("Aleatoire");
                            Random rndNumbers_x = new Random();
                            int rndNumber_x = 0;
                            rndNumber_x = rndNumbers_x.Next(3);


                            Random rndNumbers_y = new Random();
                            int rndNumber_y = 0;
                            rndNumber_y = rndNumbers_y.Next(3);


                            if (tab[rndNumber_x, rndNumber_y] == 0)
                            {
                                tab[rndNumber_x, rndNumber_y] = 2;
                                ok = true;
                            }
                        }
                    }


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
            else {
                label_morpions.Text = "Match Nul";
                morpion_1_1.Enabled = false;
                morpion_1_2.Enabled = false;
                morpion_1_3.Enabled = false;
                morpion_2_1.Enabled = false;
                morpion_2_2.Enabled = false;
                morpion_2_3.Enabled = false;
                morpion_3_1.Enabled = false;
                morpion_3_2.Enabled = false;
                morpion_3_3.Enabled = false;
            }
        } 

        public bool routine_victoire(int[,] tab) {
            bool victory = false;
            int win = 0;
            
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
                morpion_1_1.Enabled = false;
                morpion_1_2.Enabled = false;
                morpion_1_3.Enabled = false;
                morpion_2_1.Enabled = false;
                morpion_2_2.Enabled = false;
                morpion_2_3.Enabled = false;
                morpion_3_1.Enabled = false;
                morpion_3_2.Enabled = false;
                morpion_3_3.Enabled = false;

                if (win == 1)
                {
                    label_morpions.Text = "Victoire";
                    return true;
                }
                else {
                    label_morpions.Text = "Perdu";
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
            un_joueur_menu op = new un_joueur_menu();
            op.Show();
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
