using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCoresRGB
{
    public partial class FrnCores : Form
    {
        public FrnCores()
        {
            InitializeComponent();
        }

        private void hsbScrollVermelho_Scroll(object sender, ScrollEventArgs e)
        {
            int valor;
            valor = hsbScrollVermelho.Value;
            txtValVermelho.Text = Convert.ToString(valor);
            
            int red=valor;
            int green = hsbScrollVerde.Value;
            int blue = hsbScrollAzul.Value;

            txtColor.BackColor = Color.FromArgb(red,green,blue);


        }

        private void hsbScrollVerde_Scroll(object sender, ScrollEventArgs e)
        {
            int valor;
            valor = hsbScrollVerde.Value;
            txtValVerde.Text = Convert.ToString(valor);

            int red = hsbScrollVermelho.Value;
            int green = valor;
            int blue = hsbScrollAzul.Value;

            txtColor.BackColor = Color.FromArgb(red, green, blue);

        }

        private void hsbScrollAzul_Scroll(object sender, ScrollEventArgs e)
        {
            int valor;
            valor = hsbScrollAzul.Value;
            txtValAzul.Text = Convert.ToString(valor);

            int red = hsbScrollVermelho.Value;
            int green = hsbScrollVerde.Value;
            int blue = valor;

            txtColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private void txtValVermelho_TextChanged(object sender, EventArgs e)
        {
            hsbScrollVermelho.Value = Convert.ToInt16(txtValVermelho.Text);
        }

        private void txtValVerde_TextChanged(object sender, EventArgs e)
        {
            hsbScrollVerde.Value = Convert.ToInt16(txtValVerde.Text);
        }

        private void txtValAzul_TextChanged(object sender, EventArgs e)
        {
            hsbScrollAzul.Value = Convert.ToInt16(txtValAzul.Text);
        }
    }
}
