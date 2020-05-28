using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class RemoveAddress : UserControl
    {
        public RemoveAddress()
        {
            InitializeComponent();
        }

        private void RemoveAddress_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
        
        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox1.DisplayMember = "address";
            comboBox1.DataSource = AddressData.getLista();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Debe de escoger una dirección");
                }
                else
                {
                    ConnectionBD.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = '{comboBox1.SelectedValue}'");
                    MessageBox.Show("Se ha eliminado la dirección");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}