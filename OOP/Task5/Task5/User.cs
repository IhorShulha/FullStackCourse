using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class User
    {
        string login;
        string name;
        string surName;
        byte age;
        DateTime time;

        public byte Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value>0)
                {
                    age = value;
                }
            }
        }

        public User(string login, string name, string surName, byte age)
        {
            this.login = login;
            this.name = name;
            this.surName = surName;
            this.age = age;
            time = DateTime.Now;
        }

        public override string ToString()
        {
            return "Login: " + login + "\nName: " + name + "\nSurname: " + surName + "\nAge: " + age + "\nTime Registration: " + time;
        }
    }
}
