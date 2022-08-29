using System;

namespace OnKTLT
{
    class Program
    {
        /*
        If else
        Array = Mảng 1 chiều
        */

        
        static void Main(string[] args)
        {
            /* Nhap số Km đã đi */
            int KM = 0; /* int là Kiểu dữ liệu số ()*/
            Console.WriteLine("Vui lòng nhập số km");
            KM = int.Parse(Console.ReadLine());
            /* Console.ReadLine() => Ký tự số => Data type: char */
            /* int.Parse :: chuyển char => int */

            /* Vòng lập while => KM > 50 or KM < 0 */
            /* 
            || => hoặc
            && => và
            */
            while (KM > 50 || KM < 0)
            {
                Console.WriteLine("Vui lòng nhập số km");
                KM = int.Parse(Console.ReadLine());
            }
            
            /* Tạo 1 biến để chứa Tổng Tiền */
            int TongTien = 0;

            /* 45 KM 
            1 - 10km => 12k
            11 - 30km => 11k
            31 - 40km => 10k
            41 - 50km =? 9k

             */
            if (KM <= 50)
                {
                    TongTien = (KM - 40) * 9 + 10 * 10 + 10 * 11 + 10 * 12;
                }
            else if (KM <= 40)
                {
                    TongTien = (KM - 30) * 10 + 10 * 11 + 10 * 12;
                }
            else if (KM <= 30)
                {
                    TongTien = (KM - 20) * 11 + 10 * 12;
                }
            else if (KM <= 20)
                {
                    TongTien = (KM - 10) * 11 + 10 * 12;
                }
            else if (KM <= 10)
                {
                    TongTien = KM * 12;
                }

            Console.WriteLine("Khach hang di duoc {0} km và phai tra so tien la {1}", KM, TongTien);
        }
        
        
        /* Hinh Tam GIac*/
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Vui long nhap so a");
            a = int.Parse(Console.ReadLine());
            while (a > 20 || a < 1) /*<=> 1 < a < 20 */
            {
                Console.WriteLine("Vui long nhap so a");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vui long nhap so b");
            b = int.Parse(Console.ReadLine());
            while (b > 20 || b < 1 )
            {
                Console.WriteLine("Vui long nhap so b");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vui long nhap so c");
            c = int.Parse(Console.ReadLine());
            while (c > 20 || c < 1 || c >= (a + b) )
            {
                Console.WriteLine("Vui long nhap so c");
                c = int.Parse(Console.ReadLine());
            }

            Console.WriteLine ("Ban da tao ra tam giac");

            if ( a == b && b == c )
            {
                Console.WriteLine("Day la Tam giac deu");
            }
            else if (a == b || a == c || b == c) {
                Console.WriteLine("Day la Tam giac can");
            }
            else if ( a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == a*a + b*b ) {
                /*  */
                Console.WriteLine("Day la Tam giac vuong");
            }
            else {
                Console.WriteLine("Day la Tam giac thuong");
            }
        }*/
        /* 
            int [] arr = 1 chiều
            int [,] arr = 2 chiều
            int [,,] arr = 3 chiều
         */

        
        /* Bài 2 : Mảng */
        
        
        static void NhapDuLieu (int n, int [] arrMang)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nhap pha tu {} :", i);
                arrMang[i] = int.Parse(Console.ReadLine());
            }
        }

        static bool XetSoNguyenTo (int n)
        {
            if (n < 2){
                return false;
            }       
            for (int i = 2; i < (n - 1); i++){ // giảm số bước xuống còn 1 nửa
                if (n % i == 0){
                    return false;
                }   
            }
            return true;
        }
        static void CountSoNguyenTo (int n, int [] arrMang)
        {
            int DemSoNguyenTo = 0;
            for (int i = 0; i < n ; i++){
                if(XetSoNguyenTo(arrMang[i])){
                    DemSoNguyenTo++;
                }
            }
            Console.WriteLine("Co {} so nguyen to trong mang", DemSoNguyenTo);
        }

        static void CountSoChan (int n, int [] arrMang) {
            int DemSoChan = 0;
            for (int i = 0; i < n ; i++) {
                if(arrMang[i] % 2 == 0) {
                    DemSoChan++;
                }
            }
            Console.WriteLine("Co {} so chan trong mang", DemSoChan);
        }

        static void TotalX (int n, int [] arrMang) {
            
            Console.Write("Nhap so x:");
            int x = int.Parse(Console.ReadLine());
            int TongCacSoX = 0;
            for (int i = 0; i < n ; i++){
                if(arrMang[i] > x){
                    TongCacSoX = TongCacSoX + arrMang[1];
                }
            }
            Console.WriteLine("Tong cac so x la" + TongCacSoX);
        }
        
        static void SapXepTangDan (int n, int [] arrMang) {
            int tam;
            for(int i = 0; i < n - 1; i++){
                for(int j = i + 1; j < n; j++){
                    if(arrMang[i] > arrMang[j]){
                        tam = arrMang[i];
                        arrMang[i] = arrMang[j];
                        arrMang[j] = tam;        
                }
            }
            for (int y = 0; y < n ; y++) {
                Console.WriteLine(arrMang[i]);
            }
            }
        }

        bool SoLe (int n)
        {
            for (int i = 0; i < n ; i++){
                if(arrMang[i] % 2 == 0){
                    return false;
                }
            }
            return true;
        }
        static void SapXepSoLeGiamDan (int n, int [] arrMang) {
            int tam;
            for(int i = 0; i < n - 1; i++){
                for(int j = i + 1; j < n; j++){
                    if( SoLe(arrMang[i]) && SoLe(arrMang[i]) && arrMang[i] < arrMang[j]){
                        tam = arrMang[i];
                        arrMang[i] = arrMang[j];
                        arrMang[j] = tam;        
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Nhap so phan tu cau mang: ");
            n = int.Parse(Console.ReadLine());
            int [] arrMang;
            arrMang = new int[n];

            do
            {
                Console.WriteLine("1. Nhap mang");
                Console.WriteLine("2. Dem so phan tu chan");
                Console.WriteLine("3. Dem so nguyen to");
                Console.WriteLine("4. Dem cac phan tu co gia tri lon hon x");
                Console.WriteLine("5. Sap xep theo thu tu tang dan");
                Console.WriteLine("6. Xuat phan tu le theo thu tu tang dan");
                Console.WriteLine("Nhap chuc nang");
                int iChucNang = int.Parse(Console.ReadLine());
                switch (iChucNang)
                {
                    case 1: //Nhap Du Lieu cua Mnag
                    {
                        NhapDuLieu(n, arrMang);
                        break;
                    }
                    case 2: // Dem so chan
                    {
                        CountSoChan(n, arrMang);
                        break;
                    }
                    case 3: // So Nguyen To
                    {
                        CountSoNguyenTo(n, arrMang);
                        break;
                    }
                    case 4: // Tong ptu > x
                    {
                        TotalX(n, arrMang);
                        break;
                    }
                    case 5: // Sap xep Tang dan
                    {
                        SapXepTangDan(n, arrMang);
                        break;
                    }
                    case 6: // So lẽ = sap xep thu tu giam dan
                    {
                        SapXepSoLeGiamDan(n, arrMang);
                        break;
                    }
                    default:
                        break;
                }
            } while (true);
        }
        

    }
}
