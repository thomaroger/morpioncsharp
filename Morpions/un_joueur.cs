﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Morpions
{
    public partial class un_joueur : Form
    {
        int[,] tab = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int niveau = 0;
        int joueur = 0;
        int joueur2 = 1;
        int id;

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
                    
                    

                    if (tab[0, 0] == tab[2, 2] && tab[0, 0] == 1 && tab[1, 1] == 2 && tab[0, 1]==0 && joue == false)
                    {
                        tab[0, 1] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[0, 2] && tab[2, 0] == 1 && tab[1, 1] == 2 && tab[0, 1] == 0 && joue == false)
                    {
                        tab[0, 1] = 2;
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


                    if (tab[1, 0] == tab[1, 1] && tab[1, 0] == 1 && tab[1, 2] == 0 && joue == false)
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



                    // Tactiques

                    if (tab[1, 1] == 1 && tab[0, 0] == 2 && ((tab[2, 2] == 1 && tab[2, 0] == 0 && tab[0, 2] == 0) || (tab[2, 2] == 0 && tab[2, 0] == 1 && tab[0, 2] == 0) || (tab[2, 2] == 0 && tab[2, 0] == 0 && tab[0, 2] == 1)) && joue == false)
                    {
                        if (tab[2, 2] == 1 && joue == false ) {
                            tab[2, 0] = 2;
                            joue = true;
                        }

                        if (tab[0, 2] == 1 && joue == false)
                        {
                            tab[2, 0] = 2;
                            joue = true;
                        }

                        if (tab[2, 0] == 1 && joue == false)
                        {
                            tab[2, 2] = 2;
                            joue = true;
                        }
                    }


                    if (tab[1, 0] == tab[0, 1] && tab[1, 0] == 1 && tab[0, 0] == 0 && joue == false) {
                        tab[0, 0] = 2;
                        joue = true;
                    }

                    if (tab[1, 0] == tab[2, 1] && tab[1, 0] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[2, 1] == tab[1, 2] && tab[2, 1] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[1, 2] == tab[0, 1] && tab[1, 2] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

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

                    if (tab[2, 2] == tab[1, 0] && tab[2, 2] == 1 && tab[2, 0] == 0 && joue == false)
                    {
                        tab[2, 0] = 2;
                        joue = true;
                    }

                    if (tab[0, 2] == tab[2, 1] && tab[2, 1] == 1 && tab[2, 2] == 0 && joue == false)
                    {
                        tab[2, 2] = 2;
                        joue = true;
                    }

                    if (tab[0, 0] == tab[1, 2] && tab[0, 0] == 1 && tab[0, 2] == 0 && joue == false)
                    {
                        tab[0, 2] = 2;
                        joue = true;
                    }

                    if (tab[2, 0] == tab[0, 1] && tab[2, 0] == 1 && tab[0, 0] == 0 && joue == false)
                    {
                        tab[0, 0] = 2;
                        joue = true;
                    }

                    if ((tab[0, 0] == 1 || tab[2, 2] == 1 || tab[0, 2] == 1 || tab[2, 0] == 1) && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if ((tab[0, 1] == 1 || tab[1, 0] == 1 || tab[2, 1] == 1 || tab[1, 2] == 1) && tab[1, 1] == 0 && joue == false)
                    {
                        tab[1, 1] = 2;
                        joue = true;
                    }

                    if (tab[1, 1] == 1 && joue == false) {
                        tab[0, 0] = 2;
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

                // Chaîne de connexion
                string connectString = "database=Morpions;server=localhost;Integrated Security=true";
                // Objet connection
                SqlConnection connection = new SqlConnection(connectString);
                // Ouverture
                connection.Open();
                // Objet Command
                Console.WriteLine(id);
                SqlCommand command2 = new SqlCommand("SELECT USER_DRAW_COMPUTER FROM [USER] WHERE [USER_ID] = " + id, connection);
                // Objet DataReader
                SqlDataReader reader2 = command2.ExecuteReader();
                Object[] row = null;
                int nb_tmp = 0;
                while (reader2.Read())
                {
                    row = new Object[reader2.FieldCount];
                    reader2.GetValues(row);
                    nb_tmp = int.Parse(row.GetValue(0).ToString());
                }
                nb_tmp = nb_tmp + 1;
                Console.WriteLine(nb_tmp);
                connection.Close();

                string connectString2 = "database=Morpions;server=localhost;Integrated Security=true";
                // Objet connection
                SqlConnection connection2 = new SqlConnection(connectString2);
                connection2.Open();
                SqlCommand command = new SqlCommand("UPDATE [USER] SET [USER_DRAW_COMPUTER]=" + nb_tmp + "  WHERE [USER_ID] = " + id, connection2);
                // Objet DataReader
                SqlDataReader reader = command.ExecuteReader();
                connection2.Close();


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
                    // Chaîne de connexion
                    string connectString = "database=Morpions;server=localhost;Integrated Security=true";
                    // Objet connection
                    SqlConnection connection = new SqlConnection(connectString);
                    // Ouverture
                    connection.Open();
                    // Objet Command
                    Console.WriteLine(id);
                    SqlCommand command2 = new SqlCommand("SELECT USER_WIN_COMPUTER FROM [USER] WHERE [USER_ID] = " + id, connection);
                    // Objet DataReader
                    SqlDataReader reader2 = command2.ExecuteReader();
                    Object[] row = null;
                    int nb_tmp = 0;
                    while (reader2.Read())
                    {
                        row = new Object[reader2.FieldCount];
                        reader2.GetValues(row);
                        nb_tmp = int.Parse(row.GetValue(0).ToString());
                    }
                    nb_tmp = nb_tmp + 1;
                    Console.WriteLine(nb_tmp);
                    connection.Close();

                    string connectString2 = "database=Morpions;server=localhost;Integrated Security=true";
                    // Objet connection
                    SqlConnection connection2 = new SqlConnection(connectString2);
                    connection2.Open();
                    SqlCommand command = new SqlCommand("UPDATE [USER] SET [USER_WIN_COMPUTER]=" + nb_tmp + "  WHERE [USER_ID] = " + id, connection2);
                    // Objet DataReader
                    SqlDataReader reader = command.ExecuteReader();
                    connection2.Close();
                    return true;
                }
                else {
                    label_morpions.Text = "Perdu";
                    // Chaîne de connexion
                    string connectString = "database=Morpions;server=localhost;Integrated Security=true";
                    // Objet connection
                    SqlConnection connection = new SqlConnection(connectString);
                    // Ouverture
                    connection.Open();
                    // Objet Command
                    Console.WriteLine(id);
                    SqlCommand command2 = new SqlCommand("SELECT USER_LOSE_COMPUTER FROM [USER] WHERE [USER_ID] = " + id, connection);
                    // Objet DataReader
                    SqlDataReader reader2 = command2.ExecuteReader();
                    Object[] row = null;
                    int nb_tmp = 0;
                    while (reader2.Read())
                    {
                        row = new Object[reader2.FieldCount];
                        reader2.GetValues(row);
                        nb_tmp = int.Parse(row.GetValue(0).ToString());
                    }
                    nb_tmp = nb_tmp+1 ;
                    Console.WriteLine(nb_tmp);
                    connection.Close();

                    string connectString2 = "database=Morpions;server=localhost;Integrated Security=true";
                    // Objet connection
                    SqlConnection connection2 = new SqlConnection(connectString2);
                    connection2.Open();
                    SqlCommand command = new SqlCommand("UPDATE [USER] SET [USER_LOSE_COMPUTER]=" + nb_tmp + "  WHERE [USER_ID] = " + id, connection2);
                    // Objet DataReader
                    SqlDataReader reader = command.ExecuteReader();
                    connection2.Close();
                    return true;
                }
               
            }
            return false;
        }

        public un_joueur()
        {
        }

        public un_joueur(int lvl,int id_joueur) {
            InitializeComponent();
            niveau = lvl;
             id = id_joueur;

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur.ActiveForm.Close();
            un_joueur_menu op = new un_joueur_menu(id);
            op.Show();
        }

        private void case_Click(object sender, EventArgs e)
        {
            Button bouton = (System.Windows.Forms.Button)sender;
            int num1 = int.Parse(bouton.Name.Substring(8, 1));
            int num2 = int.Parse(bouton.Name.Substring(10, 1));

            if (tab[num1 - 1, num2 - 1] == 0)
            {
                bouton.Text = "X";
                bouton.Update();
                tab[num1 - 1, num2 - 1] = 1;
                if (!routine_victoire(tab))
                {
                    ia(tab, niveau);
                }
            }
        }

        private void un_joueur_Load(object sender, EventArgs e)
        {

        }
    }
}
