using System;

namespace Program_tong_hop_15_Mar_2021
{
    class Program
    {
        static void Main(string[] args)
        {   

            int SoNguyen;
            Console.WriteLine("1. Giai phuong trinh bac 2 mot an");
            Console.WriteLine("2. Tinh chu vi va dien tich hinh chu nhat");
            Console.WriteLine("3. Tinh tien dien");
            Console.WriteLine("4. Kiem tra tam giac");
            Console.WriteLine("5. Ket thuc chuong trinh");
            Console.Write("Nhap chuc nang ban muon su dung: ");
            SoNguyen = int.Parse(Console.ReadLine());

            switch (SoNguyen)
            {
                case 1:
                    {
                        Console.WriteLine("Chuong trinh 1. Giai phuong trinh bac 2 mot an");

                        // Nguoi dung Nhap cac he so a, b, c
                        double a, b, c;
                        Console.Write("Nhap He So a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap He So b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap He So c: ");
                        c = Convert.ToDouble(Console.ReadLine());

                        double delta = b * b - 4 * a * c;
                        double x1, x2, xKep;

                        // Pt co 2 nghiem
                        if (delta > 0)
                        {
                            Console.WriteLine("Ta co delta = " + delta + "\n" + "Vi delta > 0, nen Phuong trinh co 2 nghiem phan biet la: ");
                            x1 = (-b - Math.Sqrt(delta) / (2 * a));
                            x2 = (-b + Math.Sqrt(delta) / (2 * a));
                            Console.WriteLine(x1);
                            Console.WriteLine(x2);

                        }
                        // Pt co nghiem kep
                        else if (delta == 0)
                        {
                            Console.WriteLine("Ta co delta = " + delta + "\n" + "Nen Phuong trinh co nghiem kep la: ");
                            xKep = -b / (2 * a);
                            Console.WriteLine(xKep);
                        }
                        // Pt vo nghiem
                        else
                        {
                            Console.WriteLine("Ta co delta = " + delta + "\n" + "Vi delta < 0, Nen Phuong trinh vo nghiem");
                        };
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Chuong trinh 2. Tinh chu vi va dien tich hinh chu nhat");
                        int a, b;
                        Console.Write("Nhap chieu dai: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Nhap chieu rong: ");
                        b = int.Parse(Console.ReadLine());

                        Console.WriteLine("Chi vi cua hinh chu nhat la: " + (a * 2 + b * 2));
                        Console.WriteLine("Dien tich cua hinh chu nhat la: " + (a * b));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Chuong trinh 3. Tinh tien dien");

                        int Moi, Cu;
                        int T1 = 1400; // Luong KW tu 1 -> 100
                        int T2 = 1600; // Luong KW tu 101 -> 150
                        int T3 = 1800; // Luong KW tu 151 -> 200
                        int T4 = 2200; // Luong KW tu 201 -> 300
                        int T5 = 3000; // Luong KW tu >300


                        Console.Write("Nhap chi so dien cu: ");
                        Cu = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap chi so dien moi: ");
                        Moi = Convert.ToInt32(Console.ReadLine());

                        int LuongDienTieuThu = Moi - Cu;
                        int TienDien;
                        Console.WriteLine("Vay Luong dien tieu thu trong thang cua ban la: " + LuongDienTieuThu);


                        if (LuongDienTieuThu < 100)
                        {
                            TienDien = LuongDienTieuThu * T1;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                        else if (LuongDienTieuThu > 100 && LuongDienTieuThu < 50)
                        {
                            TienDien = 100 * T1 + (150 - 100) * T2;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                        else if (LuongDienTieuThu > 150 && LuongDienTieuThu < 200)
                        {
                            TienDien = 100 * T1 + 50 * T2 + (200 - 150) * T3;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                        else if (LuongDienTieuThu > 200 && LuongDienTieuThu < 300)
                        {
                            TienDien = 100 * T1 + 50 * T2 + 50 * T3 + (300 - 200) * T4;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                        else if (LuongDienTieuThu > 300)
                        {
                            TienDien = 100 * T1 + 50 * T2 + 50 * T3 + 100 * T4 + (LuongDienTieuThu - 300) * T5;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Chuong trinh 4. Kiem tra tam giac");
                        // Nguoi dung nhap Do dai cac canh a, b, c
                        double a, b, c;
                        Console.Write("Nhap do dai canh a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap do dai canh b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap do dai canh c: ");
                        c = Convert.ToDouble(Console.ReadLine());

                        double a2, b2, c2;
                        a2 = a * a;
                        b2 = b * b;
                        c2 = c * c;

                        if (a == b && b == c && c == a)
                        {
                            Console.WriteLine("Tam giac nay la tam giac deu");
                        }
                        else if (a == b || b == c || c == a)
                        {
                            Console.WriteLine("Tam giac nay la tam giac can");
                        }
                        else if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2)
                        {
                            Console.WriteLine("Tam giac nay la tam giac vuong");
                        }
                        else { Console.WriteLine("Tam giac nay la tam giac thuong"); }
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Cam on ban da su dung");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
