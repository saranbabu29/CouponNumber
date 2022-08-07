using System;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int coupon=0;
            int number;
            int temp=0;
            Console.WriteLine("How many Coupons you want");
            number = int.Parse(Console.ReadLine());
            temp = coupon;
            for (int i = 1; i <= number; i++)
            {
                Random random = new Random();
                coupon = random.Next(100000,999999 );
                
                    if (coupon != temp)
                    {
                        Console.WriteLine(coupon);
                    }
            }
        }
    }
}
