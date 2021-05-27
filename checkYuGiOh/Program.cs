using System;

namespace checkYuGiOh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n here:   ");
            int n = int.Parse(Console.ReadLine());

            checkYuGiOh(n);

           
        }
        public static void checkYuGiOh(int n) //function
        {
            int[] numberAray = new int[n];

            int j = 1;

            Console.Write("[");

            for (int i = 0; i < n; i++)
            {

                numberAray[i] = j;
                j++;
            }

            for (int i = 0; i < n; i++)
            {
                if (((numberAray[i] % 2) == 0) && ((numberAray[i] % 3) == 0) && ((numberAray[i] % 5) == 0))
                {
                    Console.Write("yu-gi-oh, ");
                    continue;
                }
                else if (((numberAray[i] % 2) == 0) && ((numberAray[i] % 3) == 0))
                {
                    Console.Write("yu-gi, ");
                    continue;
                }
                else if (((numberAray[i] % 2) == 0) && ((numberAray[i] % 5) == 0))
                {
                    Console.Write("yu-oh, ");
                    continue;
                }
                else if (((numberAray[i] % 3) == 0) && ((numberAray[i] % 5) == 0))
                {
                    Console.Write("gi-oh, ");
                    continue;
                }
                else if (((numberAray[i] % 2) == 0))
                {
                    Console.Write("yu, ");
                    continue;
                }
                else if (((numberAray[i] % 3) == 0))
                {
                    Console.Write("gi, ");
                    continue;
                }
                else if (((numberAray[i] % 5) == 0))
                {
                    Console.Write("oh, ");
                    continue;
                }
                else
                {
                    Console.Write(numberAray[i] + ", ");
                    continue;
                }
            }
            Console.Write("]");

        }
    }
}
