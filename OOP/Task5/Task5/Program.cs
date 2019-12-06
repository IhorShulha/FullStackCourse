using System;

namespace Task5
{
    class Program
    {
        static string _myString(string variableName)
        {
            Console.Write("Enter your " + variableName + ": ");
            return Console.ReadLine();

        }

        static void Main(string[] args)
        {
            /*
             * Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
             * Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании
             * экземпляра данного класса) без возможности его дальнейшего изменения.
             * Реализуйте вывод на экран информации о пользователе.
             */

            string login = _myString("login");
            string name = _myString("name");
            string surName = _myString("surName");
            byte age = Convert.ToByte(_myString("age"));
            Console.Clear();

            User u = new User(login, name, surName, age);
            Console.WriteLine(u.ToString());
            Console.ReadKey();


        }
    }
}
