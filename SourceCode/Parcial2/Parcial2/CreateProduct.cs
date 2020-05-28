using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class CreateProduct : UserControl
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idBusiness";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = BusinessData.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                throw new NotBusinessSelected("No se selecciono ningún restaurante");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) " +
                                                 $"VALUES('{comboBox1.SelectedValue}', '{textBox1.Text}');");

                    MessageBox.Show("Se agrego un producto");
                }
                catch (NotBusinessSelected ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");

                }
                
            }
        }
    }
}