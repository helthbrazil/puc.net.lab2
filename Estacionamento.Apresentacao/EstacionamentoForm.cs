﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estacionamento.Apresentacao
{
    public partial class EstacionamentoForm : Form
    {
        public EstacionamentoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                var proxy = new EstacionamentoService.Service1Client();
                var valor = proxy.Run(placa);

                proxy.Close();

                MessageBox.Show(String.Format("Placa '{0}' valor de R${1}.", placa, valor));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}