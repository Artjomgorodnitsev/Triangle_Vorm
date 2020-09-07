using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /*if(txtAA.Text.Length != 0 && txtBB.Text.Length != 0 || txtAA.Text.Length != 0 && txtCC.Text.Length != 0 || txtBB.Text.Length != 0 && txtCC.Text.Length != 0)
            {
                txtHH.Visible = false;
            }*/
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  b, c;
            //a = Convert.ToDouble(txtAA.Text);
            b = Convert.ToDouble(txtBB.Text);
            c = Convert.ToDouble(txtCC.Text);
            Triangle triangle = new Triangle( b,c);
            labelA.Text = triangle.outputAU();
            labelB.Text = triangle.outputBU();
            labelC.Text = triangle.outputCU();
            labelP.Text = Convert.ToString(Math.Round(triangle.sinA(),2));
            

        }
    }
}
