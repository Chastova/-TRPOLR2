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
        public byte КоличествоПосадочныхМест { get; }
        public byte КоличествоОкон { get; }
        public List<Оборудование> Оборудования { get; }
        public Аудитория(string название, Сотрудник ответственный, byte количествоПосадочныхМест, byte количествоОкон, List<Оборудование> оборудования)
        {
            Название = название;
            Ответственный = ответственный;
            КоличествоПосадочныхМест = количествоПосадочныхМест;
            КоличествоОкон = количествоОкон;
            Оборудования = оборудования;
        }
    }
}
