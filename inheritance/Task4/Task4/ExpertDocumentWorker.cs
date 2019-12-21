using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
