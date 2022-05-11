using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNV dsnv = new DSNV();
            dsnv.Nhap();
            dsnv.Xuat();
            dsnv.TongQuyLuong();
            dsnv.Tim();
            dsnv.Xoa();
            dsnv.Sua();
            Console.ReadLine();
        }
    }
}
