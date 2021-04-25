using System;

namespace Program_tong_hop
{
    class Program
    {
        static int XuatTong(int x, int y)
        {
            int SUM;
            SUM = x + y;
            return SUM;
        }
        static void PTBacNhat(double a, double b)
        {
            double x;
            if (a == 0)
                if (b != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                    Console.WriteLine("Phuong trinh co vo so nghiem");
            else
            {
                x = -b / a;
                Console.WriteLine("Nghiem phuong trinh la : " + x);
            }
        }
        static double MaxValue(double n)
        {
            int i;
            double s, max = 0, min = 0;
            Console.Write("Nhap vao so n: ");

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap sp thu " + i);
                s = double.Parse(Console.ReadLine());
                if (i == 1)
                {
                    max = s;
                    min = s;
                };

                if (s > max)
                {
                    max = s;
                };

                if (s < min)
                {
                    max = s;
                };
            };
            return max;
        }
        static double MaxOf_a_b_c(double a, double b, double c)
        {
            double M;
            M = a;
            if (b > M) M = b;
            if (c > M) M = c;
            return M;
        }
        static void NhapSoThuc(out double a)
        {
            Console.WriteLine("Nhap so thuc");
            a = Convert.ToDouble(Console.ReadLine());
        }
        static void NhapSoNguyen(out int n)
        {
            Console.WriteLine("Nhap so nguyen");
            n = Convert.ToInt32(Console.ReadLine());
        }
        static int Timngay(ref int days, ref int months, ref int years)
        {
            int nam_01 = 0;
            if (years % 4 == 0)
                nam_01 = 1;
            if (months == 1 || months == 3 || months == 5 || months == 7 || months == 9 || months == 10 || months == 12)
                days = 31;
            else if (months == 2)
            {
                if (nam_01 == 0)
                    days = 27;
                else
                    days = 29;
            }
            else
                days = 30;
            return days;
        }
        static void ArrayFindMinValue(double[] Arr)
        {
            double min = Arr[0];
            for (int i = 1; i <= n; i++)
            {
                if (Ar[i] < min)
                {
                    min = Ar[i];
                };
            };
            return min;
        }
        /*static bool KTSoNguyenTo(int n)
        {   
            int i;
            if (i < n)
            {
                for (i = 0; i <= n; i++)
                {

                }
            }
            else
            {

            }
        }*/
        static double GiaiThua(double n)
        {
            if (n == 0)
                return 1;
            else
                return GiaiThua(n - 1) * n;
        }
        static double DQS(double n)
        {
            if (n < 2)
                return 1;
            else
                return DQS(n - 1) + n;
        }
        static void Main(string[] args)
        {
            int c;
            for (c = 1; c <= 100; c++)
            {
                Console.WriteLine(" 1. Pham Mem Ve Cac Hinh");
                Console.WriteLine(" 2. Tim Tong 1+2+3..+n && Tim UOC va SUM cac UOC cua n number");
                Console.WriteLine(" 3. Tim gia tri lon nhat cua 1 day so thuc gom n so nhap tu ban phim");
                Console.WriteLine(" 5. Cac Chuong trinh ve De Quy");
                Console.WriteLine(" 4. Chuong Trinh Tinh Giai Thua (De Quy)");
                Console.WriteLine(" 6. Viet 100 dau * bang do - while");
                Console.WriteLine(" 7. Nhap so a, b, n trong BT2");
                Console.WriteLine(" 8. Array");
                Console.WriteLine(" 12. BT7 -  ");
                Console.WriteLine(" 13. Function (thu tuc, ham) - XuatTong");
                Console.WriteLine(" 14. Giai phuong trinh ax + b = 0");
                Console.WriteLine(" 15. Tim Max cua cac so");
                Console.WriteLine(" 16. Tra ve so ngay cua thang nam nhap vao tu ban phim");

                Console.Write("Nhap vao chuc nang ban muon dung: ");
                int ChucNang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");
                switch (ChucNang)
                {
                    case 1: // Pham Mem Ve Cac Hinh
                        {
                            int HinhNao = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Draw a Solid Square");
                            Console.WriteLine("2. Draw a Square with inside is empty");
                            Console.WriteLine("3. Draw a Rectangle");
                            Console.WriteLine("What function do you want to use? ");

                            switch (HinhNao)
                            {
                                case 1: // Draw a Square
                                    {
                                        Console.WriteLine("Chuong trinh ve Hinh Vuong");
                                        int i;
                                        int n = Convert.ToInt32(Console.ReadLine());
                                        int a;
                                        for (i = 1; i <= n; i++)
                                        {
                                            for (a = 1; a <= n; a++)
                                                Console.Write("* ");
                                            Console.WriteLine();
                                        };
                                        break;
                                    }
                                case 2: // Draw a Square with inside is empty
                                    {
                                        Console.WriteLine("Chuong trinh 4 ve Hinh Vuong Khong Ruot");
                                        int i;
                                        Console.Write("Hay nhap do dai canh cua Hinh Vuong: ");
                                        int n = Convert.ToInt32(Console.ReadLine());
                                        int a;

                                        // dong dau - DONE
                                        for (a = 1; a <= n; a++)
                                        {
                                            Console.Write("* ");
                                        }
                                        Console.WriteLine();
                                        int b = n - 2;

                                        // cac phan between
                                        for (i = 1; i <= b; i++)
                                        {
                                            Console.Write("* ");

                                            for (a = 1; a <= b; a++)
                                            {
                                                for (a = 1; a <= b; a++)
                                                    Console.Write("  ");
                                            };
                                            Console.WriteLine("*");
                                        }

                                        //dong cuoi
                                        for (a = 1; a <= n; a++)
                                            Console.Write("* ");
                                        Console.WriteLine();
                                        break;
                                    }
                                case 3: // Draw a HCN - Rong ruot or Dac ruot - Bai Tap 1
                                    {
                                        int i;
                                        Console.WriteLine("Nhap vao chieu dai:");
                                        int d = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Nhap vao chieu rong:");
                                        int r = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Chuong trinh : Ve Hinh Chu Nhat Rong ruot hoac dac ruot");
                                        Console.WriteLine("Ban muon ve loai hinh chu nhat nao?");
                                        Console.WriteLine("1. Hinh chu nhat rong ruot");
                                        Console.WriteLine("2. Hinh chu nhat dac ruot");

                                        int LoaiHCN = int.Parse(Console.ReadLine());

                                        switch (LoaiHCN)
                                        {
                                            case 1: // HCN Rong ruot
                                                {
                                                    // can viet code de kiem tra xem d co lon hon r khong?

                                                    int a;
                                                    // First Line la chieu dai - DONE
                                                    for (a = 1; a <= d; a++)
                                                    {
                                                        Console.Write("* ");
                                                    }
                                                    Console.WriteLine();

                                                    int b = d - 2;
                                                    int t = r - 2;

                                                    // cac phan between
                                                    for (i = 1; i <= t; i++)
                                                    {
                                                        Console.Write("*");

                                                        for (a = 1; a <= t; a++)
                                                        {
                                                            for (a = 1; a <= b; a++)
                                                                Console.Write("  ");
                                                        };

                                                        Console.WriteLine(" *");
                                                    }

                                                    //dong cuoi cung la chieu dai
                                                    for (a = 1; a <= d; a++)
                                                        Console.Write("* ");
                                                    Console.WriteLine();

                                                    break;
                                                }
                                            case 2: // HCN Dac ruot
                                                {


                                                    int a;

                                                    // First Line la chieu dai - DONE
                                                    for (a = 1; a <= d; a++)
                                                    {
                                                        Console.Write("* ");
                                                    }
                                                    Console.WriteLine();

                                                    int b = d - 2;
                                                    int t = r - 2;

                                                    // cac phan between
                                                    for (i = 1; i <= t; i++)
                                                    {
                                                        Console.Write("*");

                                                        for (a = 1; a <= t; a++)
                                                        {
                                                            for (a = 1; a <= b; a++)
                                                                Console.Write(" *");
                                                        };

                                                        Console.WriteLine(" *");
                                                    }

                                                    //dong cuoi cung la chieu dai
                                                    for (a = 1; a <= d; a++)
                                                        Console.Write("* ");
                                                    Console.WriteLine();
                                                    break;
                                                }
                                            default:
                                                Console.Write("Sai ma chuc nang roi");
                                                break;
                                        }

                                        break;
                                    }
                                default:
                                    Console.WriteLine("No match found");
                                    break;
                            }

                            break;
                        }
                    case 2: // Tim Tong 1+2+3..+n - Dem so luong cac UOC va SUM cac UOC cua so n
                        {
                            Console.Write("Nhap vao so n: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            //Tinh tong
                            int tongS = 0;
                            for (int i = 1; i <= n; i++)
                            {
                                tongS = tongS + i;
                            }
                            Console.Write("Tong la : {0}", tongS);
                            Console.WriteLine("-----------------------------------------");

                            /* Tim UOC va tinh Tong cua cac UOC */
                            int dem = 0;
                            int sumU = 0;
                            for (int i = 1; i <= n; i++)
                            {
                                if (n % i == 0)
                                {
                                    sumU += i; // tong = tong + i ---> tim TONG
                                    dem += 1; // dem so luong UOC
                                }
                                Console.WriteLine("So ", n, "co {0} UOC", dem);
                            }
                            break;
                        }
                    case 3: // Tim gia tri lon nhat cua 1 day so thuc gom n so nhap tu ban phim
                        {

                            Console.ReadKey();
                            break;
                        }
                    case 4: // Chuong Trinh Tinh Giai Thua - De Quy -- 12 Apr 2021
                        {
                            Console.WriteLine(" 4. Chuong Trinh Tinh Giai Thua");
                            double b, GT;
                            NhapSoThuc(out b);
                            GT = GiaiThua(b);
                            Console.WriteLine("Ket qua Giai Thua la: " + GT);
                            break;
                        }
                    case 5: // Cac Chuong trinh ve De Quy
                        {
                            Console.WriteLine("1. Giai Ham De Quy - S(n) = S(n-1) + n :-: voi n >= 2 va S(1) = 1");
                            Console.WriteLine("2. Tinh phan tu thu n cua day Fibonaci");
                            Console.WriteLine("CT nao?");
                            double a, DQ;
                            NhapSoThuc(out a);
                            DQ = a;
                            switch (DQ)
                            {
                                case 1:
                                    {
                                        double b, S;
                                        NhapSoThuc(out b);
                                        S = DQS(b);
                                        Console.WriteLine("Ket qua tinh la: " + S);
                                        break;
                                    }
                                case 2:
                                    {

                                        break;
                                    }
                            }
                            break;
                        }
                    case 6: // Viet 100 dau * bang do - while
                        {   /* int n = 100;
                            int i;
                            do
                            {
                                Console.WriteLine("*");
                                i++;
                            }
                            while (i <= n);*/
                            break;
                        }
                    case 7: // BT 2
                        {
                            Console.WriteLine("Nhap so nguyen a");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap so nguyen b");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap so nguyen n");
                            int n = int.Parse(Console.ReadLine());

                            Console.WriteLine("7.1 Tinh SUM cac so nguyen duong <n chia het cho 1 but khong chia het cho b");
                            Console.WriteLine("7.2 Dem so luong so chan trong day [a, b]");
                            int aHAYb = int.Parse(Console.ReadLine());

                            switch (aHAYb)
                            {

                                case 1: // cau a : Tong cac so nguyen duong nho hon n
                                    {
                                        int S = 0;
                                        int i;

                                        for (i = 1; i < n; i++)
                                        {
                                            if (i % a == 0 && i % b != 0)
                                            {
                                                S = S + i;
                                            }
                                        }
                                        Console.WriteLine("Tong cac <n va %a = 0 but %b != 0 la: " + S);
                                        break;
                                    }
                                case 2: // cau b : So luong so chan trong day
                                    {
                                        int i;

                                        int dem = 0;
                                        for (i = a; i <= b; i++)
                                        {
                                            if (i % 2 == 0)
                                            {
                                                dem++;
                                            }

                                        }
                                        Console.WriteLine("So luong so chan trong day [a,b] la : " + dem);
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Chon sai so roi");
                                    break;
                            }


                            break;
                        }
                    case 8: //Array
                        {
                            Console.WriteLine("1. Kieu Mang So Nguyen");
                            Console.WriteLine("2. Kieu Mang So Thuc");
                            Console.Write("Chon loai mang di: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int KieuMang = a;
                            Console.WriteLine("----------------------------------------------------");
                            switch (KieuMang)
                            {
                                case 1: // Kieu Mang So Nguyen
                                    {
                                        Console.WriteLine("Kieu Mang So Nguyen");
                                        Console.WriteLine("Nhap Kich thuoc cua mang: ");
                                        int[] Ar = new int[100];
                                        int n;
                                        NhapSoNguyen(out n);

                                        Console.WriteLine("Nhap ca phan tu cua mang");
                                        for (int i = 1; i <= n; i++)
                                        {
                                            Console.WriteLine("Nhap a[{0}]", i);
                                            Ar[i] = Convert.ToInt32(Console.ReadLine());
                                        }

                                        // Xuat ra cac phan tu cua Mang
                                        Console.WriteLine("Thanh phan cua Mang gom: ");
                                        for (int i = 1; i <= n; i++)
                                        {
                                            Console.Write(Ar[i] + ", ");
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine("Phan tu chan cua Mang nho hon 20 gom: ");
                                        for (int i = 1; i <= n; i++)
                                        {
                                            if (Ar[i] % 2 == 0 && Ar[i] < 20)
                                            {
                                                Console.Write(Ar[i] + " ");
                                            }
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine("Phan tu am co trong Mang:");
                                        for (int i = 1; i <= n; i++)
                                        {
                                            if (Ar[i] < 0)
                                            {
                                                Console.Write(Ar[i] + " ");
                                            }
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine("Xuat Mang Theo Chieu Nguoc Lai");
                                        for (int i = n; i >= 1; i--)
                                        {
                                            Console.Write(Ar[i] + ", ");
                                        }
                                        break;
                                    }
                                case 2: // Kieu Mang So Thuc
                                    {
                                        Console.WriteLine("Kieu Mang So Thuc");
                                        Console.Write("Nhap Kich thuoc cua mang: ");
                                        double[] Ar = new double[100];
                                        double n;
                                        NhapSoThuc(out n);

                                        Console.WriteLine("Nhap cac phan tu cua mang");
                                        for (int i = 0; i <= n; i++)
                                        {
                                            Console.WriteLine("Nhap a[{0}]", i);
                                            Ar[i] = Convert.ToDouble(Console.ReadLine());
                                        }

                                        // Xuat ra cac phan tu cua Mang
                                        Console.WriteLine("Thanh phan cua Mang gom: ");
                                        for (int i = 0; i <= n; i++)
                                        {
                                            Console.Write(Ar[i] + ", ");
                                        }
                                        Console.WriteLine();

                                        Console.Write("Nhap gia tri muon tim kiem: ");
                                        double v;
                                        NhapSoThuc(out v);

                                        // Thuat toan tim kiem vitri gia tri xuat hien lan dau tien
                                        for (int i = 0; i <= (int)n; i++)
                                        {
                                            if (Ar[i] == v)
                                            {
                                                Console.WriteLine("Vi tri xuat hien dau tien cua phan tu trong Mang la: " + i);
                                                break;
                                            }
                                        }

                                        // Thuat toan tim kiem vi tri gia tri xuat hien lan cuoi cung
                                        for (int i = (int)n; i >= 0; i--)
                                        {
                                            if (Ar[i] == v)
                                            {
                                                Console.WriteLine("Vi tri xuat hien cuoi cung cua phan tu trong Mang la: " + i);
                                                break;
                                            }
                                        }

                                        //Vi tri phan tu nho nhat trong Mang la
                                        double min = 0;
                                        min = ArrayFindMinValue();

                                        Console.WriteLine("Gia tri nho nhat trong Mang la: " + min);
                                        Console.WriteLine("Vi tri cua gia tri MIN la: " + index);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 9: //Mathematics
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


                                        if (LuongDienTieuThu <= 100)
                                        {
                                            TienDien = LuongDienTieuThu * T1;
                                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                                        }
                                        else if (LuongDienTieuThu > 100 && LuongDienTieuThu < 50)
                                        {
                                            TienDien = (100 * T1) + ((LuongDienTieuThu - 100) * T2);
                                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                                        }
                                        else if (LuongDienTieuThu > 150 && LuongDienTieuThu < 200)
                                        {
                                            TienDien = 100 * T1 + 50 * T2 + (LuongDienTieuThu - 150) * T3;
                                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                                        }
                                        else if (LuongDienTieuThu > 200 && LuongDienTieuThu < 300)
                                        {
                                            TienDien = 100 * T1 + 50 * T2 + 50 * T3 + (LuongDienTieuThu - 200) * T4;
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
                                        Console.WriteLine("Ban nhap sai so!");
                                        break;
                                    }
                            }
                        }
                    case 13: // Function (thu tuc, ham) - XuatTong
                        {
                            Console.WriteLine("Hay Nhap so a:");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hay Nhap so b:");
                            int b = int.Parse(Console.ReadLine());

                            int Tong;
                            Tong = XuatTong(a, b);
                            Console.WriteLine("Tong cua hai so do la: " + Tong);

                            break;
                        }
                    case 14:
                        {
                            double A, B;
                            NhapSoThuc(out A);
                            NhapSoThuc(out B);
                            PTBacNhat(A, B);
                            break;
                        }
                    case 15: // Max Value
                        {
                            double a, b, d;
                            NhapSoThuc(out a);
                            NhapSoThuc(out b);
                            NhapSoThuc(out d);
                            Console.WriteLine("Gia tri lon nhat cua cac so la: " + MaxOf_a_b_c(a, b, d));
                            break;
                        }
                    case 16: // Tra ve so ngay cua thang nam nhap vao tu ban phim
                        {
                            int day = 0;
                            Console.Write("Month: ");
                            int month = Int32.Parse(Console.ReadLine());
                            Console.Write("Year: ");
                            int year = Int32.Parse(Console.ReadLine());
                            Timngay(ref day, ref month, ref year);
                            Console.WriteLine("Thang {0} Nam {1} co {2} ngay", month, year, day);
                            break;
                        }
                    default: // write a song for you is hard, girl.. i always be sad because of you.. i cannot Pham Thi Thuy Hang 
                        Console.WriteLine("No match found");
                        break;
                };
                    Console.WriteLine("----------------------------------------------------");
                    Console.ReadKey();
            }
        }
    }
}
