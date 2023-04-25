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
            byte Численность;
            Console.Write($"Введите численность группы: ");
            while (!byte.TryParse(Console.ReadLine(), out Численность)) { 
                Console.Write($"Введены неверные данные. Введите численность группы: ");
            }
            ushort ГодПоступления;
            Console.Write($"Введите год поступления: ");
            while (!ushort.TryParse(Console.ReadLine(), out ГодПоступления) || ГодПоступления <= DateTime.Now.Year - 8 || ГодПоступления > DateTime.Now.Year)
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
            if (!((ВремяНачалаПары != "") && (TimeSpan.TryParse(ВремяНачалаПары, out TimeSpan StartTimePara))))
            {
                StartTimePara = DateTime.Now.TimeOfDay;
            }
            if (!((ВремяОкончанияПары != "") && (TimeSpan.TryParse(ВремяОкончанияПары, out TimeSpan EndTimePara))))
            {
                EndTimePara = DateTime.Now.TimeOfDay;
            }
            if (!((ВремяНачалаПерерыва != "") && (TimeSpan.TryParse(ВремяНачалаПерерыва, out TimeSpan StartTimePereriv))))
            {
                StartTimePereriv = DateTime.Now.TimeOfDay;
            }
            if (!((ВремяОкончанияПерерыва != "") && (TimeSpan.TryParse(ВремяОкончанияПерерыва , out TimeSpan EndTimePereriv))))
            {
                EndTimePereriv = DateTime.Now.TimeOfDay;
            }

            return new Пара(StartTimePara, EndTimePara, StartTimePereriv, EndTimePereriv, Смена());
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

            Console.Write("Ведите название: ");
            Название = Console.ReadLine();

            do{ Console.Write("Введите стоимость: "); } while(!decimal.TryParse(Console.ReadLine(), out Стоимость) || Стоимость <= 0);

            Console.Write("Введите дату постановки на баланс (Формат: DD.MM.YYYY): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime  ДатаПостановкиНаБаланс) || ДатаПостановкиНаБаланс > DateTime.Now)
                return new Оборудование(Название, Стоимость);
            else
                return new Оборудование(Название, Стоимость, ДатаПостановкиНаБаланс);
        }

        public static Студент Студент()
        {
            Console.WriteLine("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string отчество = Console.ReadLine();
            Console.WriteLine("Введите дату рождения формата dd.mm.yyyy: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime датаРождения))
            {
                return new Студент(фамилия, имя, отчество, Группа(), датаРождения);
            }
            else
            {
                return new Студент(фамилия, имя, отчество, Группа());
            }
        }
        public static Организация Организация()
		{
            return new Организация();
		}
	}
}
