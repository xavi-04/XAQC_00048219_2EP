using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class CreateBusiness : UserControl
    {
        public CreateBusiness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) " +
                                                 $"VALUES('{textBox1.Text}', '{textBox2.Text}');");

                    MessageBox.Show("Se agrego un negocio");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}