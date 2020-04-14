

using System;

namespace ResponsiPemrograman2757
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Nik/Nama  Gaji Bulanan");
            Console.WriteLine("=============================");
            karyawan karyawan1 = new karyawan("19022223", "Rizqi", 3000000);
            karyawan karyawan2 = new karyawan("19000223", "Elixabeth", 500000);
            karyawan karyawan3 = new karyawan("19000024", "MASHA", -4000000);
            karyawan1.infoKaryawan();
            karyawan2.infoKaryawan();
            karyawan3.infoKaryawan();
            Console.WriteLine("\nAlhamdulillah kenaikan gaji 10%!!\n");
            karyawan1.infoNaikGaji();
            karyawan2.infoNaikGaji();
            karyawan3.infoNaikGaji();
            Console.ReadKey();
        }
    }

    public class karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int KenaikanGaji { get; set; }

        public karyawan(string nik, string nama, int Gajibulanan)
        {
            Nik = nik;
            Nama = nama;

            if (Gajibulanan > 0)
            {
                GajiBulanan = Gajibulanan;
                KenaikanGaji = Convert.ToInt32(GajiBulanan * 1.1);
            }
            else
            {
                GajiBulanan = 0;
            }
        }
        public void infoKaryawan()
        {
            Console.WriteLine("{0} {1}   {2}", Nik, Nama, GajiBulanan);
        }
        public void infoNaikGaji()
        {
            double KenaikanGaji = 0;
            KenaikanGaji = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(KenaikanGaji);
            Console.WriteLine("{0} {1} {2}", Nik, Nama, GajiBulanan);
        }
    }
}

