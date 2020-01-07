using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    public static class Accauntant
    {

        public static bool AskForBonus(Worker worker, int hours) => (int)worker.PositionHours < hours;


    }
}
