using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimetrodeTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txtBase.Text != "" && txtAltura.Text != "")
            {
                int b, h, area, perimetro;
                b = Convert.ToInt32(txtBase.Text);
                h = Convert.ToInt32(txtAltura.Text);
                area = (b * h);
                perimetro = (2 * (b + h));

                resulArea.Text = area.ToString();
                resulPerimetro.Text = perimetro.ToString();

            }
            else
            {
                MessageBox.Show("Insira um Valor", "Atenção");
            }
        }
    }
}
