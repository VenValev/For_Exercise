using System;

namespace _6_Sum_vowls
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                
                if (c == 'a')
                {
                    sum += 1;
                }
                if (c == 'e')
                {
                    sum += 2;
                }
                if (c == 'i')
                {
                    sum += 3;
                }
                if (c == 'o')
                {
                    sum += 4;
                }
                if (c == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
