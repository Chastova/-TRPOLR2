using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    /// Task 5 URL: https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit
    /// </summary>
    public class Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Группа Группа { get; }
        public string ДатаРождения { get; }
        public Студент(string фамилия, string имя, string отчество, Группа группа, string датаРождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Группа = группа;
            ДатаРождения = датаРождения;
        }
    }
}