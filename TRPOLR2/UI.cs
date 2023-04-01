using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTRPOLR2;

namespace TRPOLR2
{
    class UI
    {
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"занятие.Дата_проведения = {занятие.Дата_проведения.ToShortDateString()}");
            Print(занятие.Аудитория);
            Print(занятие.Вид_занятия);
            Print(занятие.Группа);
            Print(занятие.Дисциплина);
            Print(занятие.Пара);
            Print(занятие.Сотрудник);
        }
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine($"аудитория.Название = {аудитория.Название}");
            Print(аудитория.Сотрудник);
            Console.WriteLine($"аудитория.Посадочные_Места = {аудитория.Посадочные_Места}");
            Console.WriteLine($"аудитория.Окна = {аудитория.Окна}");
            Console.WriteLine($"аудитория.Оборудования:");
            foreach (Оборудование ob in аудитория.Оборудования)
            {
                Print(ob);
            }

        }
        public static void Print(Вид_занятия вид_занятия)
        {
        }
        public static void Print(Группа группа)
        {
            Console.WriteLine($"группа.Название = {группа.Название}");
            Console.WriteLine($"группа.Сокращение = {группа.Сокращение}");
            Console.WriteLine($"группа.Численность = {группа.Численность}");
            Console.WriteLine($"группа.Год_поступления = {группа.Год_поступления}");
            Print(группа.Специальность);
            Print(группа.Классный_руководитель);
        }
        public static void Print(Дисциплина дисциплина)
        {
            Console.WriteLine($"дисциплина.Имя={дисциплина.Имя}");
            Console.WriteLine($"дисциплина.Сокращение={дисциплина.Сокращение}");
        }
        public static void Print(Пара пара)
        {
            Console.WriteLine($"Время начала пары = {пара.ЧасыНачалаПары}:{пара.МинутыНачалаПары}");
            Console.WriteLine($"Время окончания пары = {пара.ЧасыКонцаПары}:{пара.МинутыКонцаПары}");
            Console.WriteLine($"Время начала перерыва = {пара.ЧасыНачалаПерерыва}:{пара.МинутыНачалаПерерыва}");
            Console.WriteLine($"Время окончания перерыва = {пара.ЧасыКонцаПерерыва}:{пара.МинутыКонцаПерерыва}");
            Print(пара.Смена);
        }
        public static void Print(Смена смена)
        {
            Console.WriteLine($"смена.Название = {смена.Название}");
        }

        public static void Print(Сотрудник сотрудник)
        {
            Console.WriteLine($"сотрудник.Фамилия = {сотрудник.Фамилия}");
            Console.WriteLine($"сотрудник.Имя = {сотрудник.Имя}");
            Console.WriteLine($"сотрудник.Отчество = {сотрудник.Отчество}");
            Print(сотрудник.Должность);
        }
        public static void Print(Должность должность)
        {
        }
        public static void Print(Оборудование оборудование)
        {
            Console.WriteLine($"оборудование.Название = {оборудование.Название}");
            Console.WriteLine($"оборудование.Стоимость = {оборудование.Стоимость}");
            Console.WriteLine($"оборудование.Дата_постановки_на_баланс = {оборудование.ДатаПостановкиНаБаланс.ToShortDateString()}");
        }
        public static void Print(Специальность специальность)
        {
            Console.WriteLine("Специальность: " + специальность.Название);
            Console.WriteLine("Специальность(Сокр.): " + специальность.Сокращение);
        }
		public static void Print(Подразделение подразделение)
		{
			//Console.WriteLine($"подразделение.Название = {подразделение.Название}");
			//Print(подразделение.Организация);
		}
		public static void Print(Организация организация)
		{
		}
        public static void Print(Студент студент)
        {
            Console.WriteLine($"студент.Фамилия = {студент.Фамилия}");
            Console.WriteLine($"студент.Имя = {студент.Имя}");
            Console.WriteLine($"студент.Отчество = {студент.Отчество}");
            Console.WriteLine($"студент.Дата_рождения = {студент.Дата_рождения}");
            Print(студент.Группа);
        }
    }
}
