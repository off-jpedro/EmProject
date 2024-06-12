using Domain.Enum;

namespace Domain.Models
{
    public class Aluno
    {
        public int Matricula {get; set;}
        public string? Nome {get; set;}
        public string? CPF { get; set; }
        public DateTime? Nascimento { get; set; }
        public Sexo? Sexo { get; set; }
    }
}