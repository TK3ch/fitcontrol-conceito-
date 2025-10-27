namespace Dominio
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public int AcademiaId { get; set; }
    }
}