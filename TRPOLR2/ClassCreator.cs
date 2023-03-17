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
            Console.WriteLine($"Введите название группы: ");
            string Название = Console.ReadLine();
            Console.WriteLine($"Введите сокращение: ");
            string Сокращение = Console.ReadLine();
            Console.WriteLine($"Введите численность группы: ");
            bool flag_count = int.TryParse(Console.ReadLine(), out int Численность);
            while (!flag_count)
            {
                Console.WriteLine("Введены неверные данные");
                flag_count = int.TryParse(Console.ReadLine(), out Численность);
            }
            Console.WriteLine($"Введите год поступления: ");
            bool flag_year = int.TryParse(Console.ReadLine(), out int Год_поступления);
            while (!flag_year)
            {
                Console.WriteLine("Введены неверные данные");
                flag_year = int.TryParse(Console.ReadLine(), out Год_поступления);
            }
            return new Группа(Название, Сокращение, Численность, Год_поступления, Специальность(), Сотрудник());
        }
        public static Специальность Специальность()
        {
            return new Специальность();
        }
        public static Дисциплина Дисциплина()
        {
            Console.Write($"Введите имя: ");
            string имя = Console.ReadLine();
            Console.Write($"Введите сокращение: ");
            string сокращение = Console.ReadLine();
            return new Дисциплина(имя, сокращение);
        }
        public static Пара Пара()
        {
            Console.WriteLine($"Введите часы начала пары: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыНачалаПары))
            {
                if (ЧасыНачалаПары < 0 || ЧасыНачалаПары >= 23)
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
            Console.WriteLine("Введите фамилию: ");
            string Фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string Имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string Отчество = Console.ReadLine();
            return new Сотрудник(Фамилия, Имя, Отчество, Должность());
        }
        public static Должность Должность()
        {
            return new Должность();
        }
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
    }
}
