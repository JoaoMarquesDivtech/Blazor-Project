using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Data.Entities
{
    public class Tarefa :BaseDal
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public DateTime DataDoAniversario { get; set; } = DateTime.MinValue;
        public DateTime DataDeCriacao { get; set; } = DateTime.MinValue;
    }
}
