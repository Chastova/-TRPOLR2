using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
	public class Подразделение
	{
<<<<<<< HEAD
		public string Название { get; }
		public Сотрудник Сотрудник { get; }
		public Организация Организация { get; }
		public Подразделение(string название, Сотрудник сотрудник, Организация организация)
		{
			Название = название;
			Организация = организация;
			Сотрудник = сотрудник;
		}
		public Подразделение(string название, Организация организация)
		{
			Название = название;
			Организация = организация;
		}
	}
=======
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
>>>>>>> 4782b9a2d6559e6cba7861a5dacef7c1dd4e67d7
}
