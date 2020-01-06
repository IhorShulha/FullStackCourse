using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXTHandler.Change");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler.Open");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler.Save");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler.Create");
        }
    }
}
