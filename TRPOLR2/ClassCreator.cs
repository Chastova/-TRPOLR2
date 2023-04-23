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
            string Фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string Имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string Отчество = Console.ReadLine();
            return new Сотрудник(Фамилия, Имя, Отчество, Должность());
        }
        public static Подразделение Подразделение()
        {
<<<<<<< HEAD
			Console.Write("Введите название подразделения ");
			string названиеподразделения = Console.ReadLine();
			return new Подразделение(названиеподразделения, Сотрудник(), Организация());
		}
        public static Организация Организация()
        {
            return new Организация();
=======
            Console.WriteLine($"Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine();
            return new Подразделение(Название, Сотрудник(), Организация());
>>>>>>> 4782b9a2d6559e6cba7861a5dacef7c1dd4e67d7
        }
        public static Должность Должность()
        {
            return new Должность();
        }
        public static Оборудование Оборудование()
        {
            string Название;
            decimal Стоимость;
            DateTime Дата_постановки_на_баланс;

            Console.Write("Ведите название: ");
            Название = Console.ReadLine();

            do{ Console.Write("Введите стоимость: "); } while(!decimal.TryParse(Console.ReadLine(), out Стоимость) || Стоимость <= 0);

            do{ Console.Write("Введите дату постановки на баланс (Формат: DD.MM.YYYY): "); } while (!DateTime.TryParse(Console.ReadLine(), out Дата_постановки_на_баланс) || Дата_постановки_на_баланс > DateTime.Now);

            return new Оборудование(Название, Стоимость, Дата_постановки_на_баланс);
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
                int day2 = Convert.ToInt32(day);
                int month2 = Convert.ToInt32(month);
                int year2 = Convert.ToInt32(year);
                while ((year2 < 1 || year2 > 2023) || (month2 < 1 || month2 > 12) || (day2 < 1 || day2 > 31) || (day2 > 28 && month2 == 2))
                {
                    Console.WriteLine("Введите дату правильно");
                    return Студент();
                }
                
                
                if ((year2>0 && year2 <2024) && (month2 > 0 && month2 < 13) && (day2 > 0 && day2 < 32) &&(day2 < 29 && month2 == 2))
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
