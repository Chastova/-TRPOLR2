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
        public DateTime ДатаПостановкиНаБаланс { get; }


        public Оборудование(string название, decimal стоимость)
        {
            Название = название;
            Стоимость = стоимость;
            ДатаПостановкиНаБаланс = DateTime.Now;
        }

        public Оборудование(string название, decimal стоимость, DateTime датаПостановкиНаБаланс):this(название, стоимость)
        {
            ДатаПостановкиНаБаланс = датаПостановкиНаБаланс;
        }
    }
}
