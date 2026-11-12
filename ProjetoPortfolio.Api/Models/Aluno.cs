using System.Text.Json.Serialization;

namespace ProjetoPortfolio.Api.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreAluno { get; set; }
        public string AreaAtuacao { get; set; }
        public string Tecnologias { get; set; }
        public string Habilidades { get; set; }
        public string Ferramentas { get; set; }
        public int TurmaId { get; set; }

        [JsonIgnore]
        public Turma ? Turma { get; set; }

    }
}
