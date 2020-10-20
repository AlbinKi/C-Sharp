using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace kodtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Between(5, 1, 10));
            Console.WriteLine(Between(5, 10, 1));
            Console.WriteLine(Between(0, 10, 100));
            Console.WriteLine(Between(1, 1, 5));

            var array = new int[] { 1, 2, 3 };
            var array2 = new int[] { -10, 0, 100 };

            array = Double(array);
            array2 = Double(array2);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }


            Console.WriteLine(Compress("AAAAA"));
            Console.WriteLine(Compress("AAABBB"));
            Console.WriteLine(Compress("AABBAACC"));
            Console.WriteLine(Compress("AAABBCCXXXY"));

        }

        public static bool Between(int numberInbetween, int number1, int number2)
        {
            bool isBetween = false;

            if (numberInbetween <= number1 && numberInbetween >= number2 || numberInbetween <= number2 && numberInbetween >= number1)
            {
                isBetween = true;
            }

            return isBetween;
        }

        public static int[] Double(int[] maptodouble)
        {
            for (int i = 0; i < maptodouble.Length; i++)
            {
                maptodouble[i] *= 2;
            }

            return maptodouble;
        }

        public static string Compress(string stringToCompress)
        {
            StringBuilder sb = new StringBuilder();
            int? counter = 0;
            var lastChar = 'A';
            var firstLoop = true;
            foreach (var character in stringToCompress)
            {
                if (character != lastChar && !firstLoop)
                {
                    if (counter == 1)
                    {
                        counter = null;
                    }
                    sb.Append($"{counter}{lastChar}");
                    counter = 0;
                }
                lastChar = character;
                firstLoop = false;
                counter++;
            }

            if (counter == 1)
            {
                counter = null;
            }

            sb.Append($"{counter}{lastChar}");

            return sb.ToString();
        }
    }
}
