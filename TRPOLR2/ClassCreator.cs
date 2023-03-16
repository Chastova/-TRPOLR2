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
            Console.WriteLine($"Введите часы начала пары: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыНачалаПары))
            {
                if (ЧасыНачалаПары<0 || ЧасыНачалаПары>=23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыНачалаПары = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыНачалаПары = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты начала пары: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыНачалаПары))
            {
                if (МинутыНачалаПары < 0 || МинутыНачалаПары >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыНачалаПары = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыНачалаПары = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы окончания пары: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыКонцаПары))
            {
                if (ЧасыКонцаПары < 0 || ЧасыКонцаПары >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыКонцаПары = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыКонцаПары = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты окончания пары: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыКонцаПары))
            {
                if (МинутыКонцаПары < 0 || МинутыКонцаПары >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыКонцаПары = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыКонцаПары = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы начала перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыНачалаПерерыва))
            {
                if (ЧасыНачалаПерерыва < 0 || ЧасыНачалаПерерыва >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыНачалаПерерыва = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыНачалаПерерыва = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты начала перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыНачалаПерерыва))
            {
                if (МинутыНачалаПерерыва < 0 || МинутыНачалаПерерыва >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыНачалаПерерыва = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыНачалаПерерыва = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы окончания перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыКонцаПерерыва))
            {
                if (ЧасыКонцаПерерыва < 0 || ЧасыКонцаПерерыва >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыКонцаПерерыва = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыКонцаПерерыва = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты окончания перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыКонцаПерерыва))
            {
                if (МинутыКонцаПерерыва < 0 || МинутыКонцаПерерыва >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыКонцаПерерыва = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыКонцаПерерыва = DateTime.Now.Minute;
            }
            return new Пара(ЧасыНачалаПары, МинутыНачалаПары, ЧасыКонцаПары, МинутыКонцаПары, 
                ЧасыНачалаПерерыва, МинутыНачалаПерерыва, ЧасыКонцаПерерыва, МинутыКонцаПерерыва, Смена());
        }
        public static Смена Смена()
        {
            return new Смена();
        }
        public static Сотрудник Сотрудник()
        {
            return new Сотрудник();
        }
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
    }
}
