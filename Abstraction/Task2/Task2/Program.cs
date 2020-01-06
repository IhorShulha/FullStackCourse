using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player#1");
            Player Player1 = new Player();
            Player1.Play();
            (Player1 as IPlayable).Stop();
            Player1.Record();
            (Player1 as IRecodable).Stop();


            Console.WriteLine("Player#2");
            Player Player2 = new Player();
            Player2.Play();
            (Player2 as IPlayable).Stop();
            Player2.Record();
            (Player2 as IRecodable).Stop();
        }
    }
}
