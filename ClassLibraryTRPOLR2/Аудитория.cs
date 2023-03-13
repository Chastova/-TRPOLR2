using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Аудитория
    {
        public string Название { get; }
        public Сотрудник Сотрудник { get; }
        public int Посадочные_Места { get; }
        public int Окна { get; }
        public List<Оборудование> Оборудования { get; }
        public Аудитория(string название, Сотрудник сотрудник, int посадочные_места, int окна, List<Оборудование> оборудования)
        {
            Название = название;
            Сотрудник = сотрудник;
            Посадочные_Места = посадочные_места;
            Окна = окна;
            Оборудования = оборудования;
        }
    }
}
