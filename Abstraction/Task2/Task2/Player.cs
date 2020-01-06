using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
    }
}
