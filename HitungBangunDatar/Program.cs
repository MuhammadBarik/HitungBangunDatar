using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitungBangunDatar
{
    public class PersegiPanjang
    {

        public double panjang, lebar;

        public void sisiPP()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasPP(double p, double l)
        {
            return p * l;
        }

        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi panjang = " + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }

    public class Persegi
    {

        public double sisi, sysi;

        /// <summary>
        /// membuat method input alas dan tinggi
        /// </summary>
        public void sisiP()
        {
            Console.Write("Masukkan sisi1 = ");
            sisi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan sisi2 = ");
            sysi = Convert.ToDouble(Console.ReadLine());
        }

        public double LuasP(double a, double t)
        {
            return a * t;
        }

        public void tampilP()
        {
            Console.WriteLine("Luas Persegi = " + this.LuasP(sisi, sysi));
            Console.ReadKey();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //membuat instance untuk klas PersegiPanjang, klas Ligkaran dan klas Segitiga
            PersegiPanjang pp = new PersegiPanjang();
            Persegi s3 = new HitungBangunDatar.Persegi();

            //deklarasi variabel untuk ekspresi Switch
            int pilih;
            //membuat tampilan Menu
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Persegi");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilihan (1/2/3) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    s3.sisiP();
                    s3.tampilP();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Pilihan salah !");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
