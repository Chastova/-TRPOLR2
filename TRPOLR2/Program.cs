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
                    case "Сотрудник": UI.Print(ClassCreator.Сотрудник()); break;
                    case "Группа": UI.Print(ClassCreator.Группа()); break;
                    case "Пара": UI.Print(ClassCreator.Пара()); break;
					case "Подразделение": UI.Print(ClassCreator.Подразделение()); break;
					case "Дисциплина": UI.Print(ClassCreator.Дисциплина());break;
                    case "Смена": UI.Print(ClassCreator.Смена()); break;
                    case "Специальность": UI.Print(ClassCreator.Специальность()); break;
                    case "Студент": UI.Print(ClassCreator.Студент()); break;
                    case "Оборудование": UI.Print(ClassCreator.Оборудование()); break;
                    default: Console.WriteLine("Этот класс не реализован"); break;
                }
            }
        }
    }
}
