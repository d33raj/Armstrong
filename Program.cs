using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsArmstrong(num))
            {
                Console.WriteLine(num + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(num + " is not an Armstrong number.");
            }
        }

        static bool IsArmstrong(int num)
        {
            int n = CountDigits(num);
            int temp = num;
            int sum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, n);
                temp /= 10;
            }
            return sum == num;
        }

        static int CountDigits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
    }
}
