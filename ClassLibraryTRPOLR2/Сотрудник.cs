using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    ///Variant 9: https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit
    /// </summary>
    public class Сотрудник
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Должность Должность { get; }
        public Сотрудник(string фамилия, string имя, string отчество, Должность должность)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Должность = должность;
        }
    }
}