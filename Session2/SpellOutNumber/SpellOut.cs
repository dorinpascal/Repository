using System;

namespace SpellOutNumber
{
    public class SpellOut
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AmountInWords(69));
        }

        public static string AmountInWords(int n)
        {
            if (n == 0)
                return "";
            else if (n > 0 && n <= 19)
            {
                var arr = new string[]
                {
                     "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                    "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
                };
                return arr[n - 1] + " ";
            }
            else if (n >= 20 && n <= 99)
            {
               
                var arr = new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
               
                return arr[n / 10 - 2] + " " + AmountInWords(n % 10);
            }
            else if (n >= 100 && n <= 199)
            {
                if (n==100)
                {
                    return "One Hundred  " + AmountInWords(n % 100);
                }
                else return "One Hundred And " + AmountInWords(n % 100);
            }
            else if (n >= 200 && n <= 999)
            {
                return AmountInWords(n / 100) + "Hundred  " + AmountInWords(n % 100);
            }
            else if (n >= 1000 && n <= 1999)
            {
                return "One Thousand " + AmountInWords(n % 1000);
            }
            else if (n >= 2000 && n <= 999999)
            {
                return AmountInWords(n / 1000) + "Thousand " + AmountInWords(n % 1000);
            }
            else if (n >= 1000000 && n <= 1999999)
            {
                return "One Million " + AmountInWords(n % 1000000);
            }
            else if (n >= 1000000 && n <= 999999999)
            {
                return AmountInWords(n / 1000000) + "Million " + AmountInWords(n % 1000000);
            }
            else if (n >= 1000000000 && n <= 1999999999)
            {
                return "One Billion " + AmountInWords(n % 1000000000);
            }
            else
            {
                return AmountInWords(n / 1000000000) + "Billion " + AmountInWords(n % 1000000000);
            }
        }
    }
}