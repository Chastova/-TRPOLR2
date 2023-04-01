using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=sharing
    /// </summary>
    public class Аудитория
    {
        public string Название { get; }
        public Сотрудник Ответственный { get; }
        public int КоличествоПосадочныхМест { get; }
        public int КоличествоОкон { get; }
        public List<Оборудование> Оборудования { get; }
        public Аудитория(string название, Сотрудник ответственный, int количествопосадочныхмест, int количествоокон, List<Оборудование> оборудования)
        {
            Название = название;
            Ответственный = ответственный;
            КоличествоПосадочныхМест = количествопосадочныхмест;
            КоличествоОкон = количествоокон;
            Оборудования = оборудования;
        }
    }
}
