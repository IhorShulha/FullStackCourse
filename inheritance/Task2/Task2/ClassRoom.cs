using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        public List<Pupil> Pupils = new List<Pupil>();

        ClassRoom(params Pupil[] pupils)
        {
            Pupils.AddRange(pupils);
        }

        public void GetPupilsRead()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Read();
            }
        }
    }
}
