using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai2.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ucln(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
        }
        bool kiemtra_dulieu()
        {
            int n;
            if (kiemtra(textBox1.Text) || kiemtra(textBox2.Text)) return
                false;
            if (!int.TryParse(textBox1.Text, out n) || n < 0) return
                false;
            if (!int.TryParse(textBox2.Text, out n) || n < 0) return
                false;
            return true;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                int s1, s2;
                s1 = int.Parse(textBox1.Text);
                s2 = int.Parse(textBox2.Text);
                int n = ucln(s1, s2);
                textBox4.Text = ((s1 * s2) / n).ToString();
                textBox3.Text = ucln(int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text)).ToString();
            }
            else MessageBox.Show("Nhập sai dữ liệu", "Thông báo");
        }
    }
}
