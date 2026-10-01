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
            // 123 => 6 => 6 => 6 => ... => n
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

        
        static void Main (string [] args)
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
                    if (sum % 2 == 0 || sum % 3 == 0)
                    {
                        Console.WriteLine("Число не простое");
                    }
                    else
                    {
                        Console.WriteLine("Число простое");
                    }
                    break;
                }
                else
                {
                    count = findCount(sum);
                    sum = sumNumber(sum, count);
                    Console.WriteLine(sum);
                }
                Console.WriteLine(sum);
            }

            /*int thausend = n / 1000;
            int hundred = n / 100;
            int tenly = (n % 100) / 10;
            int ed = n % 10;

            int sum = thausend + hundred + tenly + ed;
            Console.WriteLine(n);
            Console.WriteLine(sum);

            if(sum % sum == 0 && sum % 2 != 0)
                Console.WriteLine("простое");
            else
                Console.WriteLine("Не простое");*/

            /*int i = 1;
            while (i <= count)
            {
                sum += (n % 10);
                for (int it = 2; it < 10; it++)
                {
                    if (sum % sum == 0 && sum % it != 0)
                    {
                        
                    }
                }
                i++;
                Console.WriteLine(sum);
            }
            Console.WriteLine("Число не простое");*/

            /*int countSum = 0;
            while (countSum > 1)
            {
                countSum = findCount(sum);
                for (int i = 0; i < countSum; i++)
                {
                    sum += (n % 10);
                    Console.WriteLine(sum);
                }
            }*/
            /*Console.WriteLine(sumNumber(n));
            int ans1 = sumNumber(n);
            if (findCount(ans1) > 1)
            {
                Console.WriteLine(sumNumber(ans1));
            }*/

        }
    }
}
