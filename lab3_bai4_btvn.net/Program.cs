using lab3_bai4_btvn.net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    private static ArrayList danhSachSinhVien = new ArrayList();

    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Chuong trinh quan ly sinh vien:");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Sua sinh vien");
            Console.WriteLine("3. Xoa sinh vien");
            Console.WriteLine("4. Xuat so luong sinh vien");
            Console.WriteLine("5. Xuat danh sach sinh vien theo lop");
            Console.WriteLine("6. Thoat");
            Console.Write("Nhap lua chon cua ban: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThemSinhVien();
                    break;
                case 2:
                    SuaSinhVien();
                    break;
                case 3:
                    XoaSinhVien();
                    break;
                case 4:
                    XuatSoLuongSinhVien();
                    break;
                case 5:
                    XuatDanhSachTheoLop();
                    break;
                case 6:
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        } while (choice != 6);
    }

    private static void ThemSinhVien()
    {
        SinhVien sv = new SinhVien();
        sv.Nhap();
        danhSachSinhVien.Add(sv);
        Console.WriteLine("Them sinh vien thanh cong.");
    }

    private static void SuaSinhVien()
    {
        Console.Write("Nhap ma so sinh vien can sua: ");
        string maSo = Console.ReadLine();
        SinhVien sv = (SinhVien)danhSachSinhVien.Cast<SinhVien>().FirstOrDefault(s => s.MaSo == maSo);
        if (sv != null)
        {
            sv.Nhap();
            Console.WriteLine("Sua sinh vien thanh cong.");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien.");
        }
    }

    private static void XoaSinhVien()
    {
        Console.Write("Nhap ma so sinh vien can xoa: ");
        string maSo = Console.ReadLine();
        SinhVien sv = (SinhVien)danhSachSinhVien.Cast<SinhVien>().FirstOrDefault(s => s.MaSo == maSo);
        if (sv != null)
        {
            danhSachSinhVien.Remove(sv);
            Console.WriteLine("Xoa sinh vien thanh cong.");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien.");
        }
    }

    private static void XuatSoLuongSinhVien()
    {
        Console.WriteLine($"So luong sinh vien: {danhSachSinhVien.Count}");
    }

    private static void XuatDanhSachTheoLop()
    {
        Console.Write("Nhap ten lop hoc: ");
        string lopHoc = Console.ReadLine();
        var sinhVienTheoLop = danhSachSinhVien.Cast<SinhVien>().Where(s => s.LopHoc == lopHoc);
        Console.WriteLine($"Danh sach sinh vien thuoc lop {lopHoc}:");
        foreach (var sv in sinhVienTheoLop)
        {
            sv.Xuat();
        }
    }
}