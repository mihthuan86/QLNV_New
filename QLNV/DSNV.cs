using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    internal class DSNV
    {
        Dictionary<string, NHANVIEN> ds;

        internal Dictionary<string, NHANVIEN> Ds { get => ds; set => ds = value; }
        public DSNV()
        {
            ds = new Dictionary<string, NHANVIEN>();
        }
        public void Nhap()
        {
            string key;
            while (true)
            {
                Console.WriteLine("Nhap phim B de cho NVBC, H cho nhan vien hop dong, 0 de thoat");
                key = Console.ReadLine();
                if (key == "B" || key == "b")
                {
                    try
                    {
                        NVBC nv = new NVBC();
                        nv.Nhap();
                        Ds.Add(nv.Manv, nv);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ma NV bi trung, kiem tra va nhap lai");
                    }
                }
                else if (key == "H" || key == "h")
                {
                    try
                    {

                        NVHD nv = new NVHD();
                        nv.Nhap();
                        Ds.Add(nv.Manv, nv);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ma NV bi trung, kiem tra va nhap lai");
                    }
                }
                else if (key == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai lua chon, moi nhap lại!");
                }

            }
            Console.WriteLine();
        }
        public void Xuat()
        {
            foreach (NHANVIEN nv in Ds.Values)
            {
                nv.Xuat();
            }
        }
        public void TongQuyLuong()
        {
            double tong = 0;
            foreach (NHANVIEN nv in Ds.Values)
            {
                tong += nv.ThucLinh();
            }
            Console.WriteLine("Tong Luong: " + tong);
        }
        public void Tim()
        {
            string manv;
            bool flag = false;
            Console.WriteLine("Nhap ma nhan vien can tim: ");
            manv = Console.ReadLine();
            foreach (NHANVIEN nv in Ds.Values)
            {
                if (manv == nv.Manv)
                {
                    nv.Xuat();
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Ko co nhan vien co ma " + manv);
            }
        }
        public void Xoa()
        {
            string manv;
            bool flag = false;
            Console.WriteLine("Nhap ma nhan vien can xoa: ");
            manv = Console.ReadLine();
            foreach (NHANVIEN nv in Ds.Values)
            {
                if (manv == nv.Manv)
                {
                    Ds.Remove(manv);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Nhan vien co ma can xoa ko ton tai");
            }
            else
            {
                Console.WriteLine("DS NV sau khi xoa");
                Xuat();
            }
        }
        public void Sua()
        {

            string manv, key = "0";
            bool flag = false, flag1 = false;
            while (true)
            {
                Console.WriteLine("Nhap ma nhan vien can sua: ");
                manv = Console.ReadLine();
                foreach (NHANVIEN nv in Ds.Values)
                {
                    if (manv == nv.Manv)
                    {
                        flag = true;
                        Console.WriteLine("Nhap thong tin sua doi: ");

                        if (nv is NVBC)
                        {
                            NVBC nvm = new NVBC();
                            nvm.Nhap();
                            try
                            {
                                Ds.Remove(nv.Manv);
                                Ds.Add(nvm.Manv, nvm);
                                flag1 = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Nhap trung ma nv,an phim bat ki de nhap lai hoac an 0 de thoat");
                                Ds.Add(nv.Manv, nv);
                                key = Console.ReadLine();

                            }
                        }
                        if (nv is NVHD)
                        {
                            NVHD nvm = new NVHD();
                            nvm.Nhap();
                            try
                            {
                                Ds.Remove(nv.Manv);
                                Ds.Add(nvm.Manv, nvm);
                                flag1 = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Nhap trung ma nv,an phim bat ki de nhap lai hoac an 0 de thoat");
                                Ds.Add(nv.Manv, nv);
                                key = Console.ReadLine();
                            }
                        }
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Khong ton tai ma nhan vien trong CSDL, Nhap lai manv hoac 0 de thoat");
                    key = Console.ReadLine();
                }
                if (key == "0")
                {
                    Console.WriteLine("an Enter ket thuc chuong trinh");
                    break;
                }
                if (flag1)
                {
                    Console.WriteLine("DS nv sau khi sua: ");
                    Xuat();
                    break;
                }
            }
        }
    }
}