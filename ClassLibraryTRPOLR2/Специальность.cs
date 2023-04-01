using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Специальность
    {
        private string название { get; }
        private string сокращение { get; }

        public Специальность(string Spec, string SpecShort)
        {
            название = Spec;
            сокращение = SpecShort;
        }
    }
}
