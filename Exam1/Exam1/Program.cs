using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {

            // bai tinh tong
            Console.WriteLine("Tong 100 so nguyen dau tien: " + Total());

            // bai tinh tong cac so chia het cho 3
            Total3();

            // bai tap tinh tien
            Console.WriteLine("Nhap so phut goi: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap loai khach hang: ");
            int cusType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So tien phai dong la: " + CaculateMoney(minute, cusType) + " Dong");
        }


        public static int CaculateMoney(int minute, int cusType)
        {
            if (cusType == 0)
            {
                // sinh vien
                return Caculate(minute - 50);
            } else if (cusType == 1)
            {
                return Caculate(minute);
            }
            return 27000;
        }


        public static int Caculate(int minute)
        {
            int money = 0;
            if (minute < 0) {
                money = 0;
            }
            if (minute <= 200)
            {
                money = ((int)(120 * minute * 1.1));
            }
            else if (200 < minute && minute <= 400)
            {
                money = ((int)(((120 * 200) + (minute - 200) * 80) * 1.1));
            }
            else
            {
                money = ((int)(((120 * 200) + (200 * 80) + (minute - 400) * 40) * 1.1));
            }
            return money + 27000;
        }

        public static int Total()
        {
            int total = 0;
            int x = 1;
            while (x <= 100)
            {
                total += x;
                x++;
            }
            return total;
        }


        public static void Total3()
        {
            int i = 20;
            while(i <= 50)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }


}
