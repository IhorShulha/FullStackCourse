using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle car = new Vehicle();
            Car porshe = new Car();
            porshe.Year = 2015;
            porshe.Price = 60_000;
            porshe.Speed = 250;

            Console.WriteLine(porshe.Year);
        }
    }
}
