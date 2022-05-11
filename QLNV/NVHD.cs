using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    internal class NVHD : NHANVIEN, IPHUCAP
    {
        double mucluong;
        double thuclinh;

        public double Mucluong { get => mucluong; set => mucluong = value; }

        public NVHD()
        {
        }
        public NVHD(double mucluong)
        {
            Mucluong = mucluong;
        }

        public double PhuCap()
        {
            return this.Mucluong/10;
        }

        public override double ThucLinh()
        {
            thuclinh = this.Mucluong + this.PhuCap();
            return thuclinh;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien hop dong");
            base.Nhap();
            Console.WriteLine("Nhap muc luong: "); this.Mucluong = Double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Thong tin nhan vien hop dong");
            base.Xuat();
            Console.WriteLine("Muc Luong: " + this.Mucluong);
            Console.WriteLine("Thuc lich: " + ThucLinh());
        }
    }
}
