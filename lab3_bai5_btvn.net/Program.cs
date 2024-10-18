using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    private static int soNgauNhien;
    private static readonly object khoa = new object();

    public static void Main()
    {
        Thread thread1 = new Thread(GenerateRandomNumber);
        Thread thread2 = new Thread(CalculateSquare);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
    private static void GenerateRandomNumber()
    {
        Random random = new Random();
        while (true)
        {
            lock (khoa)
            {
                soNgauNhien = random.Next(1, 21);
                Console.WriteLine($"Thread 1: So ngau nhien sinh ra: {soNgauNhien}");
            }
            Thread.Sleep(2000); // 2 giây
        }
    }
    private static void CalculateSquare()
    {
        while (true)
        {
            lock (khoa)
            {
                int soHienTai = soNgauNhien;
                int binhPhuong = soHienTai * soHienTai;
                Console.WriteLine($"Thread 2: Binh phuong cua {soHienTai} la: {binhPhuong}");
            }
            Thread.Sleep(2000); // 2 giây
        }
    }
}
