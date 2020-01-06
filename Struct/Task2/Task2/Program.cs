using System;
using System.Linq;

namespace Task2
{
    class Program
    {

        static void Main()
        {
            //Console.WriteLine("Введите к-во поездов: ");
            //int count = Convert.ToInt32(Console.ReadLine()); ;

            const int count = 3;

            var park = new Train[count];

            for (var i = 0; i < count; i++) park[i] = GetNewTrainFromKeyboard();
            
            var sortedPark = park.OrderBy(t => t.Number).ToArray();
            PrintTrains(sortedPark);

            while (true)
            {
                Console.Write("Введите номер поезда: ");
                var num = int.Parse(Console.ReadLine());
                var trn = park.Where(t => t.Number == num);

                if (trn.Count() == 0) Console.WriteLine("Такого поезда нету");
                else PrintTrain(trn.Single());
            }
        }

        static Train GetNewTrainFromKeyboard()
        {
            var destination = ReadConsole("Введите пункт назначения: ");
            var date = ReadConsole("Введите дату отправления: ");
            var snum = ReadConsole("Введите № поезда: ");

            return new Train
            {
                Destination = destination,
                Date = date,
                Number = int.Parse(snum)
            };
        }

        static void PrintTrains(Train[] park)
        {
            Console.WriteLine("В парке сейчас находятся: ");
            foreach (var trn in park)
                PrintTrain(trn);
        }

        static void PrintTrain(Train trn)
        {
            Console.WriteLine("{0} {1}", trn.Number, trn.Destination);
        }

        static string ReadConsole(string message)
        {
            Console.Write("{0}: ", message);
            return Console.ReadLine();
        }

    }
}
