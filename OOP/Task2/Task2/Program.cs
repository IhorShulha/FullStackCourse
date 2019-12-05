using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Требуется: Создать класс с именем Rectangle.
             В теле класса создать два поля, описывающие длины сторон double side1, side2.
             Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля
             side1 и side2 инициализируются значениями аргументов.
             Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
             прямоугольника - double PerimeterCalculator().
             Создать два свойства double Area и double Perimeter с одним методом доступа get.
             Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на
             экран периметр и площадь.
             */

            Console.WriteLine("Введите длину:");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(s1, s2);
            

            Console.WriteLine("Area: {0 }; perimeter: {1}", rectangle.Perimetr, rectangle.Area);
            Console.ReadKey();
        }
    }
}
