using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai3.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {
            double n;
            if (kiemtra(textBox1.Text) ||kiemtra(textBox2.Text) || kiemtra(textBox3.Text)) return
                false;
            if (!double.TryParse(textBox1.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(textBox2.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(textBox3.Text, out n) || n < 0)
                return false;
            return true;
        }
        bool kt_tamgiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                if (kt_tamgiac(a, b, c))
                {
                    Double p = (a + b + c) / 2;
                    LbKQ.Text = "Diện tích của tam giác:" +Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString("F3");
                }
                else LbKQ.Text = "Ba cạnh không lập thành tam giác"; 
            }
            else MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo"); 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(textBox1.Text); b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                if (kt_tamgiac(a, b, c))
                    LbKQ.Text = "Chu vi của tam giác:" + (a + b + c).ToString("F3");
                else LbKQ.Text = "Ba cạnh không lập thành tam giác"; 
              }
            else MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
