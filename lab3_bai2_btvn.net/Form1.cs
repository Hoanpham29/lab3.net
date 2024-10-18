using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai2_btvn.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxTrungTo.Enabled = true;
            btnChuyenHauTo.Enabled = false;
            btnThoat.Enabled = true;
            richTextBoxHauTo.Visible = false;
        }

        private void richTextBoxTrungTo_TextChanged(object sender, EventArgs e)
        {
            btnChuyenHauTo.Enabled = !string.IsNullOrEmpty(richTextBoxTrungTo.Text.Trim());
        }

        private void btnChuyenHauTo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxTrungTo.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập biểu thức trung tố đầy đủ.", "Thông báo");
                return;
            }

            richTextBoxTrungTo.Enabled = false;
            string bieuThucHauTo = ChuyenHauTo(richTextBoxTrungTo.Text);
            richTextBoxHauTo.Text = bieuThucHauTo;
            richTextBoxHauTo.Visible = true;
        }

        private string ChuyenHauTo(string bieuThucTrungTo)
        {
            Stack<char> stack = new Stack<char>();
            List<string> result = new List<string>();
            string number = "";

            foreach (char c in bieuThucTrungTo)
            {
                if (char.IsDigit(c))
                {
                    number += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        result.Add(number);
                        number = "";
                    }

                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (stack.Peek() != '(')
                        {
                            result.Add(stack.Pop().ToString());
                        }
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Any() && GetPriority(stack.Peek()) >= GetPriority(c))
                        {
                            result.Add(stack.Pop().ToString());
                        }
                        stack.Push(c);
                    }
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                result.Add(number);
            }

            while (stack.Any())
            {
                result.Add(stack.Pop().ToString());
            }

            return string.Join(" ", result);
        }

        private int GetPriority(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
