using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Worker
    {
        public PositionHours PositionHours { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Worker(PositionHours positionHours, string name, string surname)
        {
            PositionHours = positionHours;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append(Name + " " + Surname + " \n");
            data.Append("Position: " + Enum.GetName(typeof(PositionHours), PositionHours) + "\n");
            data.Append("Need hours a month" + ": " + (int)PositionHours);
            return data.ToString();
        }

    }
}
