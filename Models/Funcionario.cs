using System;

namespace newapi___Copia.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string? Nome { get; set; }
        public int Setorid { get; set; }
        public virtual Setor? Setor { get; set; }

    }
}
