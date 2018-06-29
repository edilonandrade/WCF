﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_WCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            //criando uma instância do nosso serviço WCF
            ServiceReference1.Service1Client WCF_ValidaEmail = new ServiceReference1.Service1Client();

            //usando o método ValidarEmail do nosso serviço
            if (WCF_ValidaEmail.ValidarEmail(txtEmail.Text))
                MessageBox.Show("Email válido");
            
            else
                MessageBox.Show("Email inválido");
        }
    }
}
