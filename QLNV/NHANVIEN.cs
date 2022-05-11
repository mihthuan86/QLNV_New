using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    abstract class NHANVIEN
    {
        string hoten;
        int namsinh;
        string gioitinh;
        string cmnd;
        string manv;


        public string Hoten { get => hoten; set => hoten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Manv { get => manv; set => manv = value; }
        public NHANVIEN()
        {
        }

        public NHANVIEN(string hoten, int namsinh, string gioitinh, string cmnd, string manv)
        {
            Hoten = hoten;
            Namsinh = namsinh;
            Gioitinh = gioitinh;
            Cmnd = cmnd;
            Manv = manv;
        }
        
        public virtual void Nhap()
        {
            try
            {

            Console.WriteLine("Nhap ma NV : ");this.Manv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");this.Hoten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");this.Namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh: ");this.Gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");this.Cmnd = Console.ReadLine();
            }catch (Exception)
            {
                Console.WriteLine("Nhap sai dinh dang, vui long nhap lai");
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Nhan vien co ma so: " + this.Manv);
            Console.WriteLine("Ho ten: " + this.Hoten);
            Console.WriteLine("Nam sinh: "+this.Namsinh);
            Console.WriteLine("Gioi tinh: " + this.Gioitinh);
            Console.WriteLine("So CMND: " + this.Cmnd);
        }
        public abstract double ThucLinh();

    }
}
