using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change");
        }

        public override void Open()
        {
            Console.WriteLine("Open");
        }

        public override void Save()
        {
            Console.WriteLine("Save");
        }

        public override void Create()
        {
            Console.WriteLine("Create");
        }
    }
}
