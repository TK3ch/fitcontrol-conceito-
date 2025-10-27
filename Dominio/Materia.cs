namespace Dominio
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Custo { get; set; }
        public int AcademiaId { get; set; }
    }
}