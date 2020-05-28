using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class AdminWindow : Form
    {
        private UserControl current = null; 
        public AdminWindow()
        {
            InitializeComponent();
            current = createUser1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new CreateUser();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new RemoveUser();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 3);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new UpdatePassword();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 3);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new CreateBusiness();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 2);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current); 
            current = new RemoveBusiness();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new CreateProduct();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new RemoveProduct();
            tableLayoutPanel2.Controls.Add(current, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current, 2);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address" +
                                                   $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au" +
                                                   $"WHERE ao.idProduct = pr.idProduct " +
                                                   $"AND ao.idAddress = ad.idAddress " +
                                                   $"AND ad.idUser = au.idUser; ");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Se obtuvieron los datos exitosamente");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema!");
            }
        }
    }
}