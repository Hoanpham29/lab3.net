using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3_bai3_btvn.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int TinhTong(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN.Text);
                int tong = TinhTong(n);
                MessageBox.Show($"Tổng các số từ 1 đến {n} là: {tong}", "Kết quả");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi");
            }
        }
        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void btnKiemTraNguyenTo_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN.Text);
                bool laNguyenTo = KiemTraNguyenTo(n);
                if (laNguyenTo)
                {
                    MessageBox.Show($"{n} là số nguyên tố.", "Kết quả");
                }
                else
                {
                    MessageBox.Show($"{n} không phải là số nguyên tố.", "Kết quả");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi");
            }
        }
    }
}
