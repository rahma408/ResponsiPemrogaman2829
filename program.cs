using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ResponsiPemrograman2829
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112928, "bagas", 2000000);
            Karyawan karyawan2 = new Karyawan(19112929, "rizky", 1500000);
            Karyawan karyawan3 = new Karyawan(19112930, "andre", -1000000);

            Console.WriteLine("Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.karyawan();
            karyawan2.karyawan();
            karyawan3.karyawan();

            Console.WriteLine("\n\nAsikkkk Kenaikan Gaji 10%!!!\n\n");

            Console.WriteLine("Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();
            karyawan3.NaikGaji();

            Console.ReadKey();
        }
    }
}
