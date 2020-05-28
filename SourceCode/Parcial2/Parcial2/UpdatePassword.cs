using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class UpdatePassword : UserControl
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe cambiar la contraseña");
            }
            else
            {
                try
                {

                    string aux = comboBox1.SelectedItem.ToString();

                    string accion = $"update appuser set password = '{textBox1.Text}'" +
                                    $" where username = '{aux}'";
                    ConnectionBD.ExecuteNonQuery(accion);

                    MessageBox.Show("Se ha actualizado la contraseña");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }
        }
        
        private void PoblarControles()
        {
            var users = ConnectionBD.ExecuteQuery("SELECT username FROM appuser");
            var usersNames = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersNames.Add(dr[0].ToString());
            }

            comboBox1.DataSource = usersNames;
        }


        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
    }
}