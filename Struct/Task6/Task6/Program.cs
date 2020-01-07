using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Info(new Worker(PositionHours.Junior, "Vova", "Petrov"), 299);
            Info(new Worker(PositionHours.Midlle, "Moisha", "Belchman"), 499);
            Info(new Worker(PositionHours.Midlle, "Anna", "Ivanova"), 365);
            Info(new Worker(PositionHours.Senior, "Vasiliy", "Vasiliev"), 457);
        }

        private static void Info(Worker worker, int hours)
        {
            Console.WriteLine(worker);
            Console.WriteLine("Общее число рабочих часов: " + hours);
            Console.WriteLine("Бонусы: " + Accauntant.AskForBonus(worker, hours));
            
        }
}
}
