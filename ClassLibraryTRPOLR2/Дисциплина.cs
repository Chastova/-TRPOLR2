using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Дисциплина
    {
        public string Имя { get; }
        public string Сокращение { get; }

        public Дисциплина(string имя, string сокращение)
        {
            Имя = имя;
            Сокращение = сокращение;
        }
    }
}
