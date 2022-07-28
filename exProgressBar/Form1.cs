using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exProgressBar
{
    public partial class FrnProgressBar : Form
    {
        public FrnProgressBar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt16(txtValor.Text);
            
            if (valor >=1 && valor <= 1000)
            {
                prgValor.Value = valor;
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            }
        }

        private void btnProgresso_Click(object sender, EventArgs e)
        {
          

            for (int cont = 1; cont <= 1000 ; cont++)
            {
                prgProgress.Value=cont;
                System.Threading.Thread.Sleep(2);
            }
            MessageBox.Show("Concluido");

        }
    }
}
