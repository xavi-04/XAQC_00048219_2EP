using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class RemoveProduct : UserControl
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
        
        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idProduct";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = ProductData.getLista();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("No se ha escogido un producto");
                }
                else
                {
                    ConnectionBD.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = '{comboBox1.SelectedValue}'");
                    MessageBox.Show("Se ha eliminado el producto");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}