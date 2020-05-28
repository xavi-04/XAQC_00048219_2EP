using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class UserWindow : Form
    {
        private UserControl newAddress = null;
        private UserControl newOrder = null;
        
        public UserWindow()
        {
            InitializeComponent();
            newAddress = createAddress1;
            newOrder = createOrder1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newAddress);
            newAddress = new CreateAddress();
            tableLayoutPanel1.Controls.Add(newAddress, 0, 1);
            tableLayoutPanel1.SetColumnSpan(newAddress, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newAddress);
            newAddress = new ModifyAddress();
            tableLayoutPanel1.Controls.Add(newAddress, 0, 1);
            tableLayoutPanel1.SetColumnSpan(newAddress, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newAddress);
            newAddress = new RemoveAddress();
            tableLayoutPanel1.Controls.Add(newAddress, 0, 1);
            tableLayoutPanel1.SetColumnSpan(newAddress, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(newOrder);
            newOrder = new CreateOrder();
            tableLayoutPanel2.Controls.Add(newOrder, 0, 1);
            tableLayoutPanel2.SetColumnSpan(newOrder, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(newOrder);
            newOrder = new RemoveOrder();
            tableLayoutPanel2.Controls.Add(newOrder, 0, 1);
            tableLayoutPanel2.SetColumnSpan(newOrder, 3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(newOrder);
            newOrder = new VisualizeOrder();
            tableLayoutPanel2.Controls.Add(newOrder, 0, 1);
            tableLayoutPanel2.SetColumnSpan(newOrder, 3);
        }

        private void button7_Click(object sender, EventArgs e)
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

                    MessageBox.Show("Se cambio la contraseña");

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
    }
}