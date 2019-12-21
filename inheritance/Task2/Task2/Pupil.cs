using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Pupil
    {
        public string pupilName { get; set; }

        public Pupil(string name)
        {
            pupilName = name;
        }

        private string GetPupilNameAndStatus()
        {
            return String.Format("{0} {1}", GetType().Name, pupilName);
        }

        public void Read()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Reading");
        }

        public void Write()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Writting");
        }

        public void Relax()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Relaxing");
        }

        public void Study()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Studying");
        }
    }
}
