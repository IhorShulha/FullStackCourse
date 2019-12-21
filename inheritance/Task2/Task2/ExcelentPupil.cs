using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        {

        }

        public void Read()
        {
            Console.WriteLine("{0} reads more than usual pupil", pupilName);
        }
    }
}
