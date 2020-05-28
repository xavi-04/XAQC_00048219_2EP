using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class RemoveBusiness : UserControl
    {
        public RemoveBusiness()
        {
            InitializeComponent();
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
            try
            {
                string nonQuery = $"DELETE FROM BUSINESS WHERE idBusiness ={comboBox1.SelectedValue}";
                ConnectionBD.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha eliminado el negocio");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }


        private void RemoveBusiness_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
    }
}