using System;
using System.Text;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            fizzbuzz();
            strReverse();
        }

        private static void fizzbuzz()
        {
            for(int iCount=1;iCount<=100;iCount++)
            {
                bool iD3 = iCount % 3 == 0;
                bool iD5 = iCount % 5 == 0;

                if (iD3 && iD5)
                    Console.WriteLine("fizzbuzz :" + iCount.ToString());
                else if(iD3)
                    Console.WriteLine("fizz :" + iCount.ToString());
                else
                    if(iD5)
                    Console.WriteLine("buzz :" + iCount.ToString());

            }
        }

        private static void strReverse()
        {
            Console.WriteLine("Enter Input string:");
            string sampleStr = Console.ReadLine();
            StringBuilder outputStr = new StringBuilder();
            for (int iCount = sampleStr.Length-1; iCount >= 0; iCount--)
            {
                outputStr.Append(sampleStr[iCount]);
            }

            Console.WriteLine("Reversed Output :" + outputStr.ToString());


        }
    }
}
