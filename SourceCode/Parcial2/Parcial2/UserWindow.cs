using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class UserWindow : Form
    {
        private UserControl current2 = null;
        public UserWindow()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current2);
            current2 = new CreateUser();
            tableLayoutPanel2.Controls.Add(current2, 0, 1);
            tableLayoutPanel2.SetColumnSpan(current2, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}