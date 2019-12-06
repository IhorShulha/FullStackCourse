using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать класс Employee.
             * В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
             * инициализирует поля, соответствующие фамилии и имени сотрудника.
             * Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
             * Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
             */

            Employee worker1 = new Employee("Vasya", "Pupkin");
            Console.Write($"{worker1.Name} {worker1.Surname } - ");
            worker1.Position = "Worker";
            worker1.Experience = 1;
            worker1.calculateSalary();
            Console.WriteLine();

            Employee worker2 = new Employee("Vova", "Pupkin");
            Console.Write($"{worker2.Name} {worker2.Surname } - ");
            worker2.Position = "Worker";
            worker2.Experience = 5;
            worker2.calculateSalary();
            Console.WriteLine();

            Employee manager1 = new Employee("Ivan", "Ivanov");
            Console.Write($"{manager1.Name} {manager1.Surname } - ");
            manager1.Position = "Manager";
            manager1.Experience = 3;
            manager1.calculateSalary();
            Console.WriteLine();

            //Console.ReadKey();
        }
    }
}
