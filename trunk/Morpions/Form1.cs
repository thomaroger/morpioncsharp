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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_register_Click(object sender, EventArgs e)
        {
            register op = new register();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void lb_passwordforget_Click(object sender, EventArgs e)
        {
            password_forget op = new password_forget();
            op.Show();
        }


    }
}