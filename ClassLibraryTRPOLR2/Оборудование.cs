using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    /// Task 15 url: https://docs.google.com/document/d/1ynMOoROmPiCWqPt78fnwQoIJKsoAIgdxhzp1VSjatsE/edit
    /// </summary>
    public class Оборудование
    {
        public string Название { get; }
        public decimal Стоимость { get; }
        public DateTime Дата_постановки_на_баланс { get; }

        public Оборудование(string название, decimal стоимость, DateTime дата_постановки_на_баланс)
        {
            Название = название;
            Стоимость = стоимость;
            Дата_постановки_на_баланс = дата_постановки_на_баланс;
        }
    }
}
