using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExHScrollBar
{
    public partial class frnTemperatura : Form
    {
        public frnTemperatura()
        {
            InitializeComponent();
        }

        private void hsbScroll_Scroll(object sender, ScrollEventArgs e)
        {
            int valor;
            valor = hsbScroll.Value;
            lblGraus.Text = Convert.ToString(valor) + " Graus";

            if (valor<5)
            {
                picFrio.Visible = true;
            }
            else if (valor>35)
            {
                picCalor.Visible = true;
            }
            else
            {
                picCalor.Visible = false;
                picFrio.Visible = false;
            }
        
        }
    }
}
