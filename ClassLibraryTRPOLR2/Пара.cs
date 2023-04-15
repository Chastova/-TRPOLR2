using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Пара
    {
        public TimeSpan ВремяНачалаПары { get; }
        public TimeSpan ВремяОкончанияПары { get; }
        public TimeSpan ВремяНачалаПерерыва { get; }
        public TimeSpan ВремяОкончанияПерерыва { get; }
        public Смена Смена { get; }
        public Пара(TimeSpan времяНачалаПары, TimeSpan времяОкончанияПары, TimeSpan времяНачалаПерерыва, TimeSpan времяОкончанияПерерыва, Смена смена)
        {
            ВремяНачалаПары = времяНачалаПары;
            ВремяОкончанияПары = времяОкончанияПары;
            ВремяНачалаПерерыва = времяНачалаПерерыва;
            ВремяОкончанияПерерыва = времяОкончанияПерерыва;
            Смена = смена;
        }
    } //вариант 7: https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit
}
