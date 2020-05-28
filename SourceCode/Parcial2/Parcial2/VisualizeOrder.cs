using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class VisualizeOrder : UserControl
    {
        public VisualizeOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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