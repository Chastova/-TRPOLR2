using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    /// Task 3 url: https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=sharing
    /// </summary>
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
