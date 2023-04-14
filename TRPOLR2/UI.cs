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
            Print(аудитория.Ответственный);
            Console.WriteLine($"аудитория.КоличествоПосадочныхМест = {аудитория.КоличествоПосадочныхМест}");
            Console.WriteLine($"аудитория.КоличествоОкон = {аудитория.КоличествоОкон}");
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
            Console.WriteLine($"группа.НазваниеГруппы = {группа.Название}");
            Console.WriteLine($"группа.СокращениеГруппы = {группа.Сокращение}");
            Console.WriteLine($"группа.ЧисленностьГруппы = {группа.Численность}");
            Console.WriteLine($"группа.ГодПоступления = {группа.ГодПоступления}");
            Print(группа.Специальность);
            Print(группа.КлассныйРуководитель);
        }
        public static void Print(Дисциплина дисциплина)
        {
            Console.WriteLine($"дисциплина.Имя={дисциплина.Название}");
            Console.WriteLine($"дисциплина.Сокращение={дисциплина.Сокращение}");
        }
        public static void Print(Пара пара)
        {
            Console.WriteLine($"пара.ВремяНачалаПары = {пара.ВремяНачалаПары:hh\\:mm}");
            Console.WriteLine($"пара.ВремяОкончанияПары = {пара.ВремяОкончанияПары:hh\\:mm}");
            Console.WriteLine($"пара.ВремяНачалаПерерыва = {пара.ВремяНачалаПерерыва:hh\\:mm}");
            Console.WriteLine($"пара.ВремяОкончанияПерерыва = {пара.ВремяОкончанияПерерыва:hh\\:mm}");
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
            Console.WriteLine($"оборудование.Дата_постановки_на_баланс = {оборудование.Дата_постановки_на_баланс.ToShortDateString()}");
        }
        public static void Print(Специальность специальность)
        {
            Console.WriteLine("Специальность: " + специальность.название);
            Console.WriteLine("Специальность(Сокр.): " + специальность.сокращение);
        }
		//public static void Print(Подразделение подразделение)
		//{
		//	Console.WriteLine($"Подразделение Название = {подразделение.Название}");
		//	Print(подразделение.Сотрудники);
		//	Print(подразделение.Организация);
		//}
		public static void Print(Организация организация)
		{
		}
        public static void Print(Студент студент)
        {
            Console.WriteLine($"студент.Фамилия = {студент.Фамилия}");
            Console.WriteLine($"студент.Имя = {студент.Имя}");
            Console.WriteLine($"студент.Отчество = {студент.Отчество}");
            Console.WriteLine($"студент.Дата_рождения = {студент.ДатаРождения}");
            Print(студент.Группа);
        }
    }
}
