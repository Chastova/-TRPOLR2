using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Занятие
    {
        DateTime дата_проведения;
        Дисциплина дисциплина;
        Сотрудник сотрудник;
        Аудитория аудитория;
        Группа группа;
        Пара пара;
        Вид_занятия вид_занятия;
        public Занятие(DateTime дата_проведения, Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, Вид_занятия вид_занятия)
        {
            this.дата_проведения = DateTime.Now;
            this.дисциплина = дисциплина;
            this.сотрудник = сотрудник;
            this.аудитория = аудитория;
            this.группа = группа;
            this.пара = пара;
            this.вид_занятия = вид_занятия;
        }
    }
}
