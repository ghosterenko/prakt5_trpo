using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konkov_18
{
    internal class Program
    {
        // 33 => 6 => 6 => 6
        // 123 => 6
        // 43 => 7 (+)

        static int findCount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
        static int sumNumber(int num, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += (num % 10);
                num /= 10;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = findCount(n);
            int sum = 0;

            Console.WriteLine(n);
            while (true)
            {
                sum = sumNumber(n, count);
                if (findCount(sum) <= 1)
                {
                    break;
                }
                else
                {
                    n = sum;
                    count = findCount(n);
                    Console.WriteLine(sum);
                }
            }
            Console.WriteLine(sum);
            if (sum == 2 || sum == 3 || sum == 7 || sum == 5)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }

        }
    }
}