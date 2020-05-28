using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class AdminWindow : Form
    {
        private UserControl current = null;
        private UserControl newBusiness = null;
        private UserControl newProduct = null;
        public AdminWindow()
        {
            InitializeComponent();
            current = createUser1;
            newBusiness = createBusiness1;
            newProduct = createProduct1;
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new CreateUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new RemoveUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UpdatePassword();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(newBusiness);
            newBusiness = new CreateBusiness();
            tableLayoutPanel2.Controls.Add(newBusiness, 0, 1);
            tableLayoutPanel2.SetColumnSpan(newBusiness, 2);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(newBusiness); 
            newBusiness = new RemoveBusiness();
            tableLayoutPanel2.Controls.Add(newBusiness, 0, 1);
            tableLayoutPanel2.SetColumnSpan(newBusiness, 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(newProduct);
            newProduct = new RemoveProduct();
            tableLayoutPanel3.Controls.Add(newProduct, 0, 1);
            tableLayoutPanel3.SetColumnSpan(newProduct, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(newProduct);
            newProduct = new CreateProduct();
            tableLayoutPanel3.Controls.Add(newProduct, 0, 1);
            tableLayoutPanel3.SetColumnSpan(newProduct, 2);
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
                MessageBox.Show("Ha ocurrido un error");
            }
        }

    }
}