using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    public class Специальность //https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit?usp=share_link
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
