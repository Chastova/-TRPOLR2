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
		public string Юридический_адрес { get; }
		public string Фактический_адрес { get; }

		public Руководитель Руководитель { get; }
		public Организация (string название, string юридический_адрес, string фактический_адрес, Руководитель руководитель )
		{
            Название = название;
            Юридический_адрес = юридический_адрес;
            Фактический_адрес = фактический_адрес;
            Руководитель = руководитель;

        }
	}
}
