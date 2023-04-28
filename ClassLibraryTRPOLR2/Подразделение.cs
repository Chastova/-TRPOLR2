using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
	public class Подразделение
	{
        public string Название { get; }
        public Сотрудник Руководитель { get; }
        public Организация Организация { get; }
        public Подразделение(string название, Сотрудник руководитель, Организация организация)
        {
            Название = название;
            Организация = организация;
            Руководитель = руководитель;
        }
    }
}
