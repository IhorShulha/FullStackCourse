using System;
using System.Linq;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int sum = 0;
            
            for (int i = 1; i<=5; i++)
            {
                int randomNumber = rand.Next();
                //Console.Write(randomNumber);
                //Console.WriteLine();


                sum +=randomNumber;

            }
            
            //Console.WriteLine($"Summ 5 numbers: {sum}");
            
            double aver = Convert.ToDouble(sum);
            Console.WriteLine($"Average: {aver / 5}");

        }
    }
}
