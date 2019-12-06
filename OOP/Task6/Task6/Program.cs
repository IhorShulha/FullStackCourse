using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать класс Converter.
             * В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и
             * инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - 
             * public Converter(double usd, double eur, double rub).
             * Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также
             * программа должна производить конвертацию из указанных валют в гривну.
             */

            Console.WriteLine("Введите сумму в долларах:");
            double usd = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в евро:");
            double eur = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в рублях:");
            double rub = Double.Parse(Console.ReadLine());

            Converter converter = new Converter(usd, eur, rub);
            Console.WriteLine($"{usd} USD = {converter.USD} UAH; \n{eur} EUR = {converter.EUR} UAH;  \n{rub} RUB = {converter.RUB} UAH.");
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine("Введите сумму в гривнях:");
            double uah = Double.Parse(Console.ReadLine());
            Converter convertUAH = new Converter(uah);
            Console.WriteLine($"{uah} UAH = {convertUAH.USD} USD; \n{uah} UAH ={convertUAH.EUR} EUR; \n{uah} UAH = {convertUAH.RUB} RUB.");
        }
    }
}
