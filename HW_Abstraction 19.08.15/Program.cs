using System;

namespace HW_Abstraction_19._08._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла:");
            string fileName = Console.ReadLine();

            if (fileName.Contains(".txt"))
            {
                TXTHandler txtHandler = new TXTHandler(fileName);
                txtHandler.Open();
                txtHandler.Chenge();
                txtHandler.Create();
                txtHandler.Save(); 
            }
            else if (fileName.Contains(".doc"))
            {
                DOCHandler docHandler = new DOCHandler(fileName);
                docHandler.Open();
                docHandler.Chenge();
                docHandler.Create();
                docHandler.Save();
            }
            else if (fileName.Contains(".xml"))
            {
                XMLHandler xmlHandler = new XMLHandler(fileName);
                xmlHandler.Open();
                xmlHandler.Chenge();
                xmlHandler.Create();
                xmlHandler.Save();
            }
            else {Console.WriteLine("Данный тип файла не поддерживаеться");}       
        }
    }
}
