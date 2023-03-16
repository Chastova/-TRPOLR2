using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTRPOLR2;

namespace TRPOLR2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите имя создаваемого класса: ");
                switch (Console.ReadLine())
                {
                    case "Занятие": UI.Print(ClassCreator.Занятие()); break;
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    case "Подразделение": UI.Print(ClassCreator.Подразделение()); break;
                    default: Console.WriteLine("Этот класс не реализован"); break;
                }
            }
        }
    }
}
