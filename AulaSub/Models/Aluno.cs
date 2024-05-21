using System.ComponentModel.DataAnnotations;

namespace AulaSub.Models
{
    public class Aluno
        {

            public int AlunoID { get; set; }
            [Display(Name = "Alunos")]
            [Required(ErrorMessage = "Insira o nome")]
             public string? Estudante { get; set; }
            [Display(Name = "Data Nascimento")]
            [DataType(DataType.Date)]
            public DateTime DtNasc { get; set; }
            [Display(Name = "Endereço")]
            public string? Endereco { get; set; }
            [Required(ErrorMessage = "CEP Obrigatorio")]
            public string? CEP { get; set; }
            public string? Turma { get; set; }

        }
    }

