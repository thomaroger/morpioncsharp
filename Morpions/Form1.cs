using System;
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

        private void bt_submit_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion
            string connectString = "database=Morpions;server=localhost;Integrated Security=true";
            // Objet connection
            SqlConnection connection = new SqlConnection(connectString);
            // Ouverture
            connection.Open();
            // Objet Command
            SqlCommand command = new SqlCommand("SELECT USER_LOGIN,USER_PASSWORD,USER_ID FROM [USER] WHERE USER_SURNAME = '" + tb_password.Text + "' AND USER_LOGIN = '" + tb_login.Text + "'", connection);
            // Objet DataReader
            SqlDataReader reader = command.ExecuteReader();
            Object[] row = null;
            string pass = null;
            string login = null;
            int id = 0;
            while (reader.Read())
            {
                row = new Object[reader.FieldCount];
                reader.GetValues(row);
                login = row.GetValue(0).ToString();
                pass = row.GetValue(1).ToString();
                id = int.Parse(row.GetValue(2).ToString());

            }

            // Fermeture
            connection.Close();

            // verification du login et du mot de passe avec la base de donnee
            if (tb_login.Text == "etudiant" && tb_password.Text == "password" || tb_login.Text == login && tb_password.Text == pass)
            {
                menu op = new menu();
                op.Show();
            }
            else {

                MessageBox.Show("Accès refusé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
