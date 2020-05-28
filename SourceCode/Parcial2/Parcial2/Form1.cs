﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password";
            comboBox1.DisplayMember = "username";
            comboBox1.DataSource = UserData.getLista();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            User use = (User)comboBox1.SelectedItem;
            
            try
            {
                if (comboBox1.SelectedValue.Equals(textBox1.Text))
                {
                    if (use.UserType is true)
                    {
                        AdminWindow admin = new AdminWindow();
                        admin.Show();
                        Hide();
                    }
                    else
                    {
                        UserWindow user = new UserWindow();
                        user.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
    }
}