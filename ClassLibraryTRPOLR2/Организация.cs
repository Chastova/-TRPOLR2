using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
	public class Организация
	{
		public string Название { get; }
		public string ЮридическийAдрес { get; }
		public string ФактическийAдрес { get; }
		public Сотрудник Руководитель { get; }
		public Организация (string название, string юридическийAдрес, string фактическийAдрес, Сотрудник руководитель )
		{
            Название = название;
            ЮридическийAдрес = юридическийAдрес;
            ФактическийAдрес = фактическийAдрес;
			Руководитель = руководитель;

        }
	}
}
