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
            radioButton1.Checked = true;
            /*if(txtAA.Text.Length != 0 && txtBB.Text.Length != 0 || txtAA.Text.Length != 0 && txtCC.Text.Length != 0 || txtBB.Text.Length != 0 && txtCC.Text.Length != 0)
            {
                txtHH.Visible = false;
            }*/
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double a, c;
                a = Convert.ToDouble(txtAA.Text);
                c = Convert.ToDouble(txtCC.Text);
                Triangle2 triangle = new Triangle2(a, c);
                labelA.Text = triangle.outputA();
                labelB.Text = triangle.outputB();
                labelC.Text = triangle.outputC();
                labelP.Text = Convert.ToString(Math.Round(triangle.sinA(), 2));
            }
            if (radioButton2.Checked == true)
            {
                double b, c;
                b = Convert.ToDouble(txtBB.Text);
                c = Convert.ToDouble(txtCC.Text);
                Triangle3 triangle = new Triangle3(b, c);
                labelA.Text = triangle.outputA();
                labelB.Text = triangle.outputB();
                labelC.Text = triangle.outputC();
                labelP.Text = Convert.ToString(Math.Round(triangle.cosA(), 2));
            }
            if (radioButton3.Checked == true)
            {
                double a, b;
                a = Convert.ToDouble(txtAA.Text);
                b = Convert.ToDouble(txtBB.Text);
                Triangle4 triangle = new Triangle4(a, b);
                labelA.Text = triangle.outputA();
                labelB.Text = triangle.outputB();
                labelC.Text = triangle.outputC();
                labelP.Text = Convert.ToString(Math.Round(triangle.tanA(), 2));
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            labelB.Visible = false;
            label8.Visible = true;
            label4.Visible = true;
            labelA.Visible = true;
            label7.Visible = false;
            label6.Visible = true;
            txtBB.Visible = false;
            txtAA.Visible = true;
            label2.Visible = true;
            txtCC.Visible = true;
            label10.Text = "SinA";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            labelB.Visible = true;
            label8.Visible = false;
            label7.Visible = true;
            label4.Visible = false;
            labelA.Visible = false;
            labelB.Visible = true;
            labelC.Visible = true;
            label6.Visible = true;
            txtBB.Visible = true;
            txtAA.Visible = false;
            txtCC.Visible = true;
            label2.Visible = true;
            label10.Text = "CosA";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            labelB.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            labelA.Visible = true;
            labelB.Visible = true;
            labelC.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            txtBB.Visible = true;
            txtAA.Visible = true;
            txtCC.Visible = false;
            label10.Text = "TanA";
        }
    }
}
