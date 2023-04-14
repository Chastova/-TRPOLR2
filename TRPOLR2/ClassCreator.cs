using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine($"Введите дату проведения: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime датаПроведения))
            {
                return new Занятие(датаПроведения, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
            }
            else
            {
                return new Занятие(Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
            }
        }
        public static Аудитория Аудитория()
        {
            Console.WriteLine($"Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine($"Введите кол-во посадочных мест: ");
            bool chek_pm = int.TryParse(Console.ReadLine(), out int КоличествоПосадочныхМест);
            while (!chek_pm)
            {
                Console.WriteLine("Неверный формат данных, введите заново");
                chek_pm = int.TryParse(Console.ReadLine(), out КоличествоПосадочныхМест);
            }
            Console.WriteLine($"Введите кол-во окон: ");
            bool chek_o = int.TryParse(Console.ReadLine(), out int КоличествоОкон);
            while (!chek_o)
            {
                Console.WriteLine("Неверный формат данных, введите заново");
                chek_o = int.TryParse(Console.ReadLine(), out КоличествоОкон);
            }
            List<Оборудование> оборудования = new List<Оборудование>();
            return new Аудитория(Название, Сотрудник(), КоличествоПосадочныхМест, КоличествоОкон, оборудования);

        }
        public static ВидЗанятия ВидЗанятия()
        {
            return new ВидЗанятия();
        }
        public static Группа Группа()
        {
            Console.Write($"Введите название группы: ");
            string Название = Console.ReadLine();
            Console.Write($"Введите сокращение: ");
            string Сокращение = Console.ReadLine();
            int Численность;
            Console.Write($"Введите численность группы: ");
            while (!int.TryParse(Console.ReadLine(), out Численность) || Численность <= 0) { 
                Console.Write($"Введены неверные данные. Введите численность группы: ");
            }
            int ГодПоступления;
            Console.Write($"Введите год поступления: ");
            while (!int.TryParse(Console.ReadLine(), out ГодПоступления) || ГодПоступления <= DateTime.Now.Year - 8 || ГодПоступления > DateTime.Now.Year)
            {
                Console.Write($"Введены неверные данные. Введите год поступления: ");
            }
            return new Группа(Название, Сокращение, Численность, ГодПоступления, Специальность(), Сотрудник());
        }
        public static Специальность Специальность()
        {
            Console.WriteLine("Введите название специальности: ");
            string spec = Console.ReadLine();
            Console.WriteLine("Введите сокращенное название специальности: ");
            string spec_short = Console.ReadLine();
            return new Специальность(spec, spec_short);
        }
        public static Дисциплина Дисциплина()
        {
            Console.Write($"Введите название: ");
            string имя = Console.ReadLine();
            Console.Write($"Введите сокращение: ");
            string сокращение = Console.ReadLine();
            return new Дисциплина(имя, сокращение);
        }
        public static Пара Пара()
        {
            Console.WriteLine($"Введите время начала пары в формате (HH:mm): ");
            string ВремяНачалаПары = Console.ReadLine();
            Console.WriteLine($"Введите время окончания пары в формате (HH:mm): ");
            string ВремяОкончанияПары = Console.ReadLine();
            Console.WriteLine($"Введите время начала перерыва в формате (HH:mm): ");
            string ВремяНачалаПерерыва = Console.ReadLine();
            Console.WriteLine($"Введите время окончания перерыва в формате (HH:mm): ");
            string ВремяОкончанияПерерыва = Console.ReadLine();

            return new Пара(ВремяНачалаПары, ВремяОкончанияПары, ВремяНачалаПерерыва, ВремяОкончанияПерерыва, Смена());
        }
        public static Смена Смена()
        {
            Console.WriteLine("Введите название");
            string Название = Console.ReadLine();
            return new Смена(Название);
        }
        public static Сотрудник Сотрудник()
        {
            Console.WriteLine("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string отчество = Console.ReadLine();
            return new Сотрудник(фамилия, имя, отчество, Должность());
        }
        public static Подразделение Подразделение()
        {
            Console.WriteLine($"Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine();
            return new Подразделение(Название, Сотрудник(), Организация());
        }
        public static Должность Должность()
        {
            return new Должность();
        }
        public static Оборудование Оборудование()
        {
            string Название;
            decimal Стоимость;
            DateTime ДатаПостановкиНаБаланс;

            Console.Write("Ведите название: ");
            Название = Console.ReadLine();

            do{ Console.Write("Введите стоимость: "); } while(!decimal.TryParse(Console.ReadLine(), out Стоимость) || Стоимость <= 0);

            Console.Write("Введите дату постановки на баланс (Формат: DD.MM.YYYY): ");
            if (!DateTime.TryParse(Console.ReadLine(), out ДатаПостановкиНаБаланс) || ДатаПостановкиНаБаланс > DateTime.Now)
                return new Оборудование(Название, Стоимость);
            else
                return new Оборудование(Название, Стоимость, ДатаПостановкиНаБаланс);
        }

        public static Студент Студент()
        {

            {
                Console.WriteLine("Введите фамилию: ");
                string Фамилия = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                string Имя = Console.ReadLine();
                Console.WriteLine("Введите отчество: ");
                string Отчество = Console.ReadLine();
                Console.WriteLine("Введите дату рождения формата dd.mm.yyyy: ");
                string ДатаРождения = Console.ReadLine();

                bool familia = int.TryParse(Фамилия, out int familia2);
                bool name = int.TryParse(Имя, out int name2);
                bool otchestvo = int.TryParse(Отчество, out int otchestvo2);
                if (familia || name || otchestvo)
                {

                    Console.WriteLine("Введите ФИО правильно");
                    return Студент();
                }
                while (Фамилия == string.Empty || Имя == string.Empty || Отчество == string.Empty)
                {
                    Console.WriteLine("Параметры должны быть введены");
                    return Студент();
                }


                if (ДатаРождения == string.Empty)
                {

                    Console.WriteLine("Дата рождения не введена, установлена сегодняшняя дата");
                    ДатаРождения = DateTime.Today.ToString();
                    Console.WriteLine(Фамилия + " " + Имя + " " + Отчество + " " + ДатаРождения);
                    return new Студент(Фамилия, Имя, Отчество, Группа(), ДатаРождения);

                }

                string[] split = ДатаРождения.Split('.');
                string day = split[0];
                string month = split[1];
                string year = split[2];
                bool Day = int.TryParse(day, out int day2);
                bool Month = int.TryParse(day, out int month2);
                bool Year = int.TryParse(day, out int year2);
                if (!Day || !Month || !Year)
                {

                    Console.WriteLine("Введите дату правильно1");
                    return Студент();
                }
                int day3 = Convert.ToInt32(day);
                int month3 = Convert.ToInt32(month);
                int year3 = Convert.ToInt32(year);
                while ((year3 < 1 || year3 > 2023) || (month3 < 1 || month3 > 12) || (day3 < 1 || day3 > 31) || (day3 > 28 && month3 == 2))
                {
                    Console.WriteLine("Введите дату правильно");
                    return Студент();
                }


                if ((year3 > 0 && year3 < 2024) && (month3 > 0 && month3 < 13) && (day3 > 0 && day3 < 32) && (day3 < 29 && month3 == 2))
                {
                    ДатаРождения = day2.ToString() + "." + month2.ToString() + "." + year2.ToString();

                }

                Console.WriteLine(Фамилия + " " + Имя + " " + Отчество + " " + ДатаРождения);
                return new Студент(Фамилия, Имя, Отчество, Группа(), ДатаРождения);
            }

        }
        public static Организация Организация()
		{
            return new Организация();
		}
	}
}
