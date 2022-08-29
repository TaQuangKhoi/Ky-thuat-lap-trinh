using System;

namespace Bai2
{
    class Program
    {
        
        static void NhapN (ref int n) {
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            while (n < 0) {
                Console.WriteLine("Nhap lai n: ");
                n = int.Parse(Console.ReadLine());
            }
        }

        static void TimChuSoNhoNhat (int n) {
            n % 10
        }

        static void NhapMang (int n, float [] arrMang)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nhap pha tu {0} :", i);
                arrMang[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang (int n, float [] arrMang) {
            for (int y = 0; y < n ; y++) {
                Console.WriteLine(arrMang[y]);
            }
        }

        static void KiemTraXtrongMang (int n, float [] arrMang) {
            float x;
            Console.WriteLine("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            int DemX = 0;
            for (int i = 0; i <= n; i++) {
                if (x == arrMang[i]) {
                    DemX ++;
                    Console.WriteLine ("X xuat hien tai vi tri " + i);
                }
            }
            Console.WriteLine("X xuat hien {0} lan", DemX);
        }

        static void SoSanhMang (int n, float [] arrMang) {
            Console.WriteLine("Nhap mang b");
            float [] bMang;
            bMang = new float[n];
            int Dem = 0;
            NhapMang(n, bMang);
            for (int i = 0; i <= n; i++)
            {
                if (arrMang[i] == bMang[i]) {
                    Dem++;
                }
            }
            if (Dem == n) {
                Console.WriteLine("Bang Nhau");
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            NhapN(ref n);
            float [] arrMang;
            arrMang = new float[n];
            NhapMang(n, arrMang);
            XuatMang(n, arrMang);
            KiemTraXtrongMang(n, arrMang);
            SoSanhMang(n, arrMang);
            Console.ReadLine();
        }
    }
}
