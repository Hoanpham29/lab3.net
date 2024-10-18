using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai4.net
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
            int n;
            if (kiemtra(textBox1.Text)) return false;
            if (!int.TryParse(textBox1.Text, out n) || n <= 0) return
                false;
            return true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                int S = 0, r; LbKQ.Enabled = true;
                int n = int.Parse(textBox1.Text);
                while (n != 0)
                {
                    r = n % 10;
                    S += r;
                    n = n / 10;
                }
                LbKQ.Text = "Tổng các chữ số của n là : " +S.ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                textBox1.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                float S = 0; LbKQ.Enabled = true;
                int n = int.Parse(textBox1.Text);
                for (int i = 1; i <= n; i++) S += 1.0f / i;
                LbKQ.Text = "Tổng các chữ số của n là : " +S.ToString("F3");
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                textBox1.Focus();
            }
        }
    }
}
