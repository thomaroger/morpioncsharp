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
            Form1.ActiveForm.Close();
            password_forget op = new password_forget();
            op.Show();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            // verification du login et du mot de passe avec la base de donnee
            if (tb_login.Text == "etudiant" && tb_password.Text=="password")
            {
                Menu op = new Menu();
                op.Show();
            }
            else {
                MessageBox.Show("Accès refusé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
