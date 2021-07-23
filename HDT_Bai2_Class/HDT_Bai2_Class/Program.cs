using System;

namespace HDT_Bai2_Class
{
    class animal {
        public double CanNang;
        public double ChieuCao;
        public void Info()
        {
            Console.WriteLine("Can nang :{0}kg \nChieu cao :{1}cm", CanNang, ChieuCao);
        }

    }
    class sinhvien {
        private int masv;
        private string ten;
        private double diemtoan;
        private double diemly;
        private double diemhoa;

        public int Masv {
            get { return masv; }
            set { masv = value; }
        }
        public string Ten {
            get { return ten; }
            set { ten = value; }
        }
        public double Diemtoan {
            get { return diemtoan; }
            set { if (value <= 10 && value >= 0)
                {
                    diemtoan = value;
                }
                else {
                    diemtoan = -1;
                }
            }
        }
        public double Diemly {
            get { return diemly; }
            set { diemly = value; }
        }
        public double Diemhoa {
            get { return diemhoa; }
            set { diemhoa = value; }
        }
        public static int Count = 0;
        public sinhvien() {
            Masv = 0;
            Ten = "null";
            Diemtoan = 0;
            Diemly = 0;
            Diemhoa = 0;
            Count++;
        }
        

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            animal dog = new animal();
            dog.CanNang = 50;
            dog.ChieuCao = 500;
            dog.Info();
            Console.WriteLine("So sinh vien hien tai {0}", sinhvien.Count);
            sinhvien sv1 = new sinhvien();
            Console.WriteLine("So sinh vien hien tai {0}", sinhvien.Count);
            sinhvien sv2 = new sinhvien();
            Console.WriteLine("So sinh vien hien tai {0}", sinhvien.Count);
            sinhvien sv3 = new sinhvien();
            Console.WriteLine("So sinh vien hien tai {0}", sinhvien.Count);
            sv1.Masv = 1700015;
            sv1.Ten = "Huong";
            sv1.Diemtoan = 10;
            sv2.Diemtoan = 11;
            Console.WriteLine("Ma so sinh vien : {0}", sv1.Masv);

            Console.WriteLine("Diemtoan : {0}", sv1.Diemtoan);
            Console.WriteLine("Diemtoan : {0}", sv2.Diemtoan);
            Console.WriteLine("Diemtoan : {0}", sv3.Diemtoan);
        }
    }
}
