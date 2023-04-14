using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    /// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit
    /// </summary>
    public class Группа
    {
        public string Название { get; }
        public string Сокращение { get; }
        public int Численность { get; }
        public int ГодПоступления { get; }
        public Специальность Специальность { get; }
        public Сотрудник КлассныйРуководитель { get; }
        public Группа(string название, string сокращение, int численность, int годПоступления, Специальность специальность, Сотрудник классныйРуководитель)
        {
            Название = название;
            Сокращение = сокращение;
            Численность = численность;
            ГодПоступления = годПоступления;
            Специальность = специальность;
            КлассныйРуководитель = классныйРуководитель;
        }
    }
}
