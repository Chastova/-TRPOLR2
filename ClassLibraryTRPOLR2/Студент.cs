using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Группа Группа { get; }
        public string Дата_рождения { get; }
        
        public Студент(string фамилия, string имя, string отчество, Группа группа, string дата_рождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Группа = группа;
            Дата_рождения = дата_рождения;
        }
    }
}