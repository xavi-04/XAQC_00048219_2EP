using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class ModifyAddress : UserControl
    {
        public ModifyAddress()
        {
            InitializeComponent();
        }

        private void ModifyAddress_Load(object sender, EventArgs e)
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
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacio");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{textBox1.Text}' " +
                                                 $"WHERE idAddress = {comboBox1.SelectedValue}");

                    MessageBox.Show("Se modificó la dirección");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}