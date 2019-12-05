using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать классы Point и Figure.
             * Класс Point должен содержать два целочисленных поля и одно строковое поле.
             * Создать три свойства с одним методом доступа get.
             * Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
             * Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
             * Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны
             * многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
             * Написать программу, которая выводит на экран название и периметр многоугольника.
             */

            Console.WriteLine("Hello World!");

            Point A = new Point(0, 0, "point1");
            Point B = new Point(1, 0, "point2");
            Point C = new Point(1, 1, "point3");
            Point D = new Point(0, 1, "point4");

            Figure figure = new Figure(A, B, C, D);

            figure.PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
