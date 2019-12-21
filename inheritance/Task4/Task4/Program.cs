using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DocumentWorker documentWorker = new DocumentWorker();
            ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
            ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
            
            string key = Console.ReadLine();
            
            switch (key)
            {
                case "1":
                    proDocumentWorker = new ProDocumentWorker();
                    break;
                case "2":
                    expertDocumentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker(); ;
                    break;
            }

            Console.ReadKey();
        }
    }
}
