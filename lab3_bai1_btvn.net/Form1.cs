using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai1_btvn.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GiaiPhuongTrinh(double a, double b)
        {
            if (a == 0)
            {
                if (b < 0)
                    return "Vô số nghiệm";
                else if (b == 0)
                    return "Vô định";
                else
                    return "Vô nghiệm";
            }
            else
            {
                double x = -b / a;
                return $"Phương trình có nghiệm x < {x}";
            }
        }
        private void btnGiaiPhuongTrinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                string ketQua = GiaiPhuongTrinh(a, b);
                MessageBox.Show(ketQua, "Kết quả");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho a và b.", "Lỗi");
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là nút Kiểm tra!", "Thông báo");
        }
    }
}
