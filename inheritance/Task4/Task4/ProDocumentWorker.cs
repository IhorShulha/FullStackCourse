using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ProDocumentWorker : DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public void EditDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, cохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
