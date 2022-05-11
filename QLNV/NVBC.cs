using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    internal class NVBC : NHANVIEN , IPHUCAP
    {
        double hesoluong;
        double luongcoban;
        double thuclinh;

        public double Hesoluong { get => hesoluong; set => hesoluong = value; }
        public double Luongcoban { get => luongcoban; set => luongcoban = value; }

        public NVBC()
        {
        }

        public NVBC(double hesoluong, double luongcoban)
        {
            this.Hesoluong = hesoluong;
            this.Luongcoban = luongcoban;
        }

        public double PhuCap()
        {
            return this.Luongcoban / 10;
        }

        public override double ThucLinh()
        {
            thuclinh = this.Hesoluong * this.Luongcoban + this.PhuCap();
            return thuclinh;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien bien che");
            base.Nhap();
            Console.WriteLine("Nhap he so luong: ");this.Hesoluong = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban: ");this.Luongcoban = Double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Thong tin nhan vien bien che");
            base.Xuat();
            Console.WriteLine("Luong co ban: "+this.Luongcoban);
            Console.WriteLine("He so luong: " + this.Hesoluong);
            Console.WriteLine("Thuc lich: " + ThucLinh());
        }
    }
}
