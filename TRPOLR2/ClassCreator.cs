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
            bool check_swith = false;
            DateTime Дата_проведения = DateTime.Now;
            do
            {
                Console.WriteLine("Желаете указать дату? В противном случае будет задана текущая дата (y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                    case "Y":
                        {
                            bool check_date;
                            do
                            {
                                Console.WriteLine($"Введите текущую дату. Формат: DD.MM.YYYY");
                                check_date = DateTime.TryParse(Console.ReadLine(), out Дата_проведения);
                                if (!check_date)
                                {
                                    Console.WriteLine("Дата указана неверно. Попробуйте снова...");
                                }
                            }
                            while (!check_date);
                            check_swith = true;
                            break;
                        }
                    case "n":
                    case "N":
                        {
                            Console.WriteLine("Указана текущая дата");
                            check_swith = true;
                            break;
                        }
                    default: break;
                }
            }
            while (!check_swith);
            return new Занятие(Дата_проведения, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), Вид_занятия());
        }
        public static Аудитория Аудитория()
        {
            Console.WriteLine($"Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine($"Введите кол-во посадочных мест: ");
            bool chek_pm = int.TryParse(Console.ReadLine(), out int Посадочные_места);
            while (!chek_pm)
            {
                Console.WriteLine("Неверный формат данных, введите заново");
                chek_pm = int.TryParse(Console.ReadLine(), out Посадочные_места);
            }
            Console.WriteLine($"Введите кол-во окон: ");
            bool chek_o = int.TryParse(Console.ReadLine(), out int Окна);
            while (!chek_o)
            {
                Console.WriteLine("Неверный формат данных, введите заново");
                chek_o = int.TryParse(Console.ReadLine(), out Окна);
            }
            List<Оборудование> оборудования = new List<Оборудование>();
            return new Аудитория(Название, Сотрудник(), Посадочные_места, Окна, оборудования);

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
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
        public static Организация Организация()
        {
            return new Организация();
        }
        public static Подразделение Подразделение()
        {
			Console.WriteLine($"Введите название: ");
			string Название = Console.ReadLine();
            Console.WriteLine();

            return new Подразделение(Название, Руководитель(), Организация());
        }
    }
}
