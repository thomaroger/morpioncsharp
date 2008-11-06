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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            register.ActiveForm.Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Text;
            string password2 = tb_password2.Text;
            string email = tb_email.Text;
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            if (login=="" || password=="" || password2=="" || email=="" || name=="" || surname=="") {
                MessageBox.Show("Champs obligatoires non renseignés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
