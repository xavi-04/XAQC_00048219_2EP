using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class CreateAddress : UserControl
    {
        User currentUser = new User();
        public CreateAddress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Necesita una dirección");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                                 $"VALUES({currentUser.IdUser}, '{textBox1.Text})");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}