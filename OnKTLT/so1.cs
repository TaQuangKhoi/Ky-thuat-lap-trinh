using System;

namespace OnKTLT
{
    class Program
    {
    static void Main(string[] args)
            {
                
                int SoCu = 0;
                int SoMoi = 0;
                Console.WriteLine("Vui lòng nhập chi số cu:");
                SoCu = int.Parse(Console.ReadLine());
                Console.WriteLine("Vui lòng nhập chi số mới:");
                SoMoi = int.Parse(Console.ReadLine());

                while (SoCu >= SoMoi)
                {
                    Console.WriteLine("Vui lòng nhập chi số cu:");
                    SoCu = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vui lòng nhập chi số mới:");
                    SoMoi = int.Parse(Console.ReadLine());
                }
                
                int TongDien = SoMoi - SoCu;
                int TongTien = 0;

                /* 45 KM 
                1 - 10km => 12k
                11 - 30km => 11k
                31 - 40km => 10k
                41 - 50km =? 9k

                */
                if (TongDien > 300)
                    {
                        TongTien = (TongDien - 300) * 3000 + 80 * 2000 + 70 * 1500 + 50 * 1200 + 100 * 1000;
                    }
                else if (TongDien > 220)
                    {
                        TongTien = (TongDien - 220) * 2000 + 70 * 1500 + 50 * 1200 + 100 * 1000;
                    }
                else if (TongDien > 150)
                    {
                        TongTien = (TongDien - 150) * 1500 + 50 * 1200 + 100 * 1000;
                    }
                else if (TongDien > 100)
                    {
                        TongTien = (TongDien - 100) * 1200 + 100 * 1000;
                    }
                else
                    {
                        TongTien = TongDien * 1000;
                    }

                Console.WriteLine("Khach hang dung {0} KW và phai tra so tien la {1}", TongDien, TongTien);
        }
    }
}