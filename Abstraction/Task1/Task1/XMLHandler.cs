using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XMLHendler.Change");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHendler.Create");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHendler.Open");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHendler.Save");
        }

    }
}
