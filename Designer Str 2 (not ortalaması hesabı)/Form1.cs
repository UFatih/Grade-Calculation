using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designer_Str_2__not_ortalaması_hesabı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, proje, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);
            proje = Convert.ToDouble(textBox4.Text);

            ort = (s1 + s2 + s3 + proje)/4 ;

            if (ort >= 50)


            {
                durum = "Pass";
                
            }

            else

            {
                durum = "Fail";
            }

                textBox5.Text = ort.ToString("0.000") + "  / " + durum;

        }
    }
}
