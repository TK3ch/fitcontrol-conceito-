using Dominio;
using Infraestrutura;

namespace AplicacaoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var banco = new BancoDeDados();

            for (int i = 1; i <= 10; i++)
            {
                banco.InserirAcademia(new Academia
                {
                    Nome = $""Academia {i}"",
                    Endereco = $""Rua Exemplo {i}"",
                    Telefone = $""(11) 90000-000{i}""
                });
            }

            var academias = banco.ListarAcademias();
            Console.WriteLine(""=== Sistema de Franquias de Academias ==="");
            foreach (var a in academias)
            {
                Console.WriteLine($""{a.Id} - {a.Nome} | {a.Endereco} | {a.Telefone}"");
            }

            banco.InserirAluno(new Aluno { Nome = ""Carlos"", EstaPagando = true, AcademiaId = 1 });
            banco.InserirAluno(new Aluno { Nome = ""Ana"", EstaPagando = false, AcademiaId = 2 });

            var alunos = banco.ListarAlunos();
            Console.WriteLine(""
=== Alunos Cadastrados ==="");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($""ID: {aluno.Id} | Nome: {aluno.Nome} | Pagando: {(aluno.EstaPagando ? ""Sim"" : ""Não"")} | AcademiaId: {aluno.AcademiaId}"");
            }
        }
    }
}