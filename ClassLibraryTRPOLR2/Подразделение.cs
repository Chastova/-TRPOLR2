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
        public string Руководитель { get; }
        public Сотрудник Сотрудники { get; }
        public Организация Организация { get; }
        public Подразделение(string название, Сотрудник сотрудники, Организация организация)
        {
            Название = название;
            Организация = организация;
            Сотрудники = сотрудники;
        }
    }
}
