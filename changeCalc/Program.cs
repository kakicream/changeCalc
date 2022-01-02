using System;
using System.Collections.Generic;

// 프로그래머스 코딩테스트 연습
// 부족한 금액 계산하기

namespace changeCalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long Solution(int price, int money, int count)
            {
                long sum = 0;
                for (int i = 0; i < count + 1; i++)
                {
                    sum += i;
                }
                if (price * sum <= money)
                {
                    return 0;
                }
                else
                {
                    return price * sum - money;
                }
            }

            // Test
            long result = Solution(3, 20, 4);
            Console.WriteLine(result);
        }
    }
}