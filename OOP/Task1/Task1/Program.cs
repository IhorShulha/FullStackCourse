using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать класс с именем Address.
             * В теле класса требуется создать поля: index, country, city, street, house, apartment. 
             * Для каждого поля,
             * создать свойство с двумя методами доступа.
             * Создать экземпляр класса Address.
             * В поля экземпляра записать информацию о почтовом адресе.
             * Выведите на экран значения полей, описывающих адрес.
             */
            

            Address address = new Address();

            address.Index = 49000;
            address.House = 155;
            address.Apartment = 9;

            address.Country = "Ukraine";
            address.City = "Dnipro";
            address.Street = "Nova Street";

            Console.WriteLine(address.Index);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
       
        }
    }
}
