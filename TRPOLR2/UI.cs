using ClassLibraryTRPOLR2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPOLR2
{
    class UI
    {
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"Занятие.Дата_проведения = {занятие.Дата_проведения}");
            Print(занятие.Аудитория);
            Print(занятие.Вид_занятия);
            Print(занятие.Группа);
            Print(занятие.Дисциплина);
            Print(занятие.Пара);
            Print(занятие.Сотрудник);
        }
        public static void Print(Аудитория аудитория)
        {
        }
        public static void Print(Вид_занятия вид_занятия)
        {
        }
        public static void Print(Группа группа)
        {
        }
        public static void Print(Дисциплина дисциплина)
        {
        }
        public static void Print(Пара пара)
        {
        }
        public static void Print(Сотрудник сотрудник)
        {
        }
    }
}
