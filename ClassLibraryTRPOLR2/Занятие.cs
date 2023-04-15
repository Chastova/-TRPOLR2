using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Занятие
    {
        /// <summary>
        /// Вариант №1 
        /// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit
        /// </summary>
        public DateTime ДатаПроведения { get; }
        public Дисциплина Дисциплина { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public ВидЗанятия ВидЗанятия { get; }

        public Занятие(Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, ВидЗанятия видЗанятия)
            : this(DateTime.Now, дисциплина, сотрудник, аудитория, группа, пара, видЗанятия)
        {

        }

        public Занятие(DateTime датаПроведения, Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, ВидЗанятия видЗанятия)
        {
            ДатаПроведения = датаПроведения;
            Дисциплина = дисциплина;
            Сотрудник = сотрудник;
            Аудитория = аудитория;
            Группа = группа;
            Пара = пара;
            ВидЗанятия = видЗанятия;
        }
    }
}
