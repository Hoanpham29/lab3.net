using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_bai4_btvn.net
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string LopHoc { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap lop hoc: ");
            LopHoc = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma so: {MaSo}, Ho ten: {HoTen}, Nam sinh: {NamSinh}, Dia chi: {DiaChi}, Lop hoc: {LopHoc}");
        }
    }
}
