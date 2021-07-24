using System;

namespace HDT_Bai5_KeThua
{

    public class Nguoi {
        public string Hoten;
        public int Namsinh;
        public int ChieuCao;
        public int CanNang;

        
    }
    public class SinhVien : Nguoi
    {
        public string Truong;
        public string Nganh;
    }

    class MainClass
    {
        public static void Nhap(SinhVien sv)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Nhap thong tin sinh vien ");
            Console.Write("Ho ten :");
            sv.Hoten = Console.ReadLine();
            Console.Write("Nam sinh :");
            sv.Namsinh = int.Parse(Console.ReadLine());
            Console.Write("Chieu cao :");
            sv.ChieuCao = int.Parse(Console.ReadLine());
            Console.Write("Can Nang :");
            sv.CanNang = int.Parse(Console.ReadLine());
            Console.Write("Truong :");
            sv.Truong = Console.ReadLine();
            Console.Write("Nganh :");
            sv.Nganh = Console.ReadLine();
        }

        public static void Xuat(SinhVien sv) {
            Console.WriteLine("***********");
            Console.WriteLine("Thong tin vua nhap la:");
            Console.WriteLine("Ho ten :{0}", sv.Hoten);
            Console.WriteLine("Nam sinh :{0}", sv.Namsinh);
            Console.WriteLine("Truong:{0}", sv.Truong);
        }
        public static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            Nhap(sv1);
            Xuat(sv1);  
        }
    }
}
