using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTRPOLR2;

namespace TRPOLR2
{
    static class ClassCreator
    {
        public static Занятие Занятие()
        {
            Console.WriteLine($"Введите текущую дату: ");
            string Дата_проведения = Console.ReadLine();
            return new Занятие(Дата_проведения, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), Вид_занятия());
        }
        public static Аудитория Аудитория()
        {
            return new Аудитория();
        }
        public static Вид_занятия Вид_занятия()
        {
            return new Вид_занятия();
        }
        public static Группа Группа()
        {
            return new Группа();
        }
        public static Дисциплина Дисциплина()
        {
            return new Дисциплина();
        }
        public static Пара Пара()
        {
            return new Пара();
        }
        public static Сотрудник Сотрудник()
        {
            return new Сотрудник();
        }
    }
}
