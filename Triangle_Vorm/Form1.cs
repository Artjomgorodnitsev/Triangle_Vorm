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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtA.Visible = false;
            txtH.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listView1.Items.Clear();
                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);

                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
                else listView1.Items[5].SubItems.Add("Не существует");
            }
            else if (radioButton2.Checked == true)
            {
                listView1.Items.Clear();
                double a, h;
                a = Convert.ToDouble(txtA.Text);
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(a, h);
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputH());
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.Surface2()));
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtH.Visible = false;
            txtB.Visible = true;
            txtC.Visible = true;
            txtA.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtB.Visible = false;
            txtC.Visible = false;
            txtH.Visible = true;
            txtA.Visible = true;
        }
    }
}
