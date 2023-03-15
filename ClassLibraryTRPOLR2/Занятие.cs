using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Занятие
    {
        public DateTime Дата_проведения { get; }
        public Дисциплина Дисциплина { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public Вид_занятия Вид_занятия { get; }
        public Занятие(DateTime дата_проведения, Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, Вид_занятия вид_занятия)
        {
            Дата_проведения = дата_проведения; 
            Дисциплина = дисциплина;
            Сотрудник = сотрудник;
            Аудитория = аудитория;
            Группа = группа;
            Пара = пара;
            Вид_занятия = вид_занятия;
        }
    }
}
