using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Специальность
    {
        public string Название { get; }
        public string Сокращение { get; }

        public Специальность(string Spec, string Spec_short)
        {
            Название = Spec;
            Сокращение = Spec_short;
        }
    }
}
