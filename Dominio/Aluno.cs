namespace Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public bool EstaPagando { get; set; }
        public int AcademiaId { get; set; }
    }
}