using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Employee
    {
        double tax = 0.2;
        double salary = 1000;

        public string Name { get; set; }
        public string Surname { get; set; }
        public double Experience { get; set; };
        public string Position { get; set; }


        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void calculateSalary()
        {
            if (Position == "Worker" && Experience <= 1)
            {
                salary *= Experience;
                Console.WriteLine($"Worker с опытом работы {Experience} получает {salary} до вычета налогов или чистыми {salary-(salary * tax)}");
            }
            else if (Position == "Worker" && Experience > 1)
            {
                salary *= 1.5;
                Console.WriteLine($"Worker с опытом работы {Experience} получает {salary} до вычета налогов или чистыми {salary - (salary * tax)}");
            }
            else if (Position == "Manager" && Experience < 1)
            {
                salary *= 2;
                Console.WriteLine($"Manager с опытом работы {Experience} получает {salary} до вычета налогов или чистыми {salary - (salary * tax)}");
            }
            else if (Position == "Manager" && Experience > 2)
            {
                salary *= 3;
                Console.WriteLine($"Manager с опытом работы {Experience} получает {salary} до вычета налогов или чистыми {salary - (salary * tax)}");
            }
        }
    }
}
