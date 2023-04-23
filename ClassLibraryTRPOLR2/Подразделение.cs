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
}
