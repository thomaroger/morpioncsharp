﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Morpions
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Close();
            un_joueur op = new un_joueur();
            op.Show();
        }
    }
}