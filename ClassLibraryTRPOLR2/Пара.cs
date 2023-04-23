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
        public Пара(string времяНачалаПары, string времяОкончанияПары, string времяНачалаПерерыва, string времяОкончанияПерерыва, Смена смена)
        {
            if ((времяНачалаПары != "") && (TimeSpan.TryParse(времяНачалаПары, out TimeSpan StartTimePara)))
            {
                ВремяНачалаПары = StartTimePara;
            }
            else
            {
                ВремяНачалаПары = DateTime.Now.TimeOfDay;
            }
            if ((времяОкончанияПары != "") && (TimeSpan.TryParse(времяОкончанияПары, out TimeSpan EndTimePara)))
            {
                ВремяОкончанияПары = EndTimePara;
            }
            else
            {
                ВремяОкончанияПары = DateTime.Now.TimeOfDay;
            }
            if ((времяНачалаПерерыва != "") && (TimeSpan.TryParse(времяНачалаПерерыва, out TimeSpan StartTimePereriv)))
            {
                ВремяНачалаПерерыва = StartTimePereriv;
            }
            else
            {
                ВремяНачалаПерерыва = DateTime.Now.TimeOfDay;
            }
            if ((времяОкончанияПерерыва != "") && (TimeSpan.TryParse(времяОкончанияПерерыва, out TimeSpan EndTimePereriv)))
            {
                ВремяОкончанияПерерыва = EndTimePereriv;
            }
            else
            {
                ВремяОкончанияПерерыва = DateTime.Now.TimeOfDay;
            }
            Смена = смена;
        }
    } //вариант 7: https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit
}
