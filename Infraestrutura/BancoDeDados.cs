using MySql.Data.MySqlClient;
using Dominio;

namespace Infraestrutura
{
    public class BancoDeDados
    {
        private readonly string _conexao = "server=localhost;database=sistema_academia;user=root;password=;";

        public void InserirAcademia(Academia academia)
        {
            using var conexao = new MySqlConnection(_conexao);
            conexao.Open();
            string query = "INSERT INTO Academias (Nome, Endereco, Telefone) VALUES (@nome, @endereco, @tel)";
            using var cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@nome", academia.Nome);
            cmd.Parameters.AddWithValue("@endereco", academia.Endereco);
            cmd.Parameters.AddWithValue("@tel", academia.Telefone);
            cmd.ExecuteNonQuery();
        }

        public List<Academia> ListarAcademias()
        {
            var lista = new List<Academia>();
            using var conexao = new MySqlConnection(_conexao);
            conexao.Open();
            string query = "SELECT Id, Nome, Endereco, Telefone FROM Academias";
            using var cmd = new MySqlCommand(query, conexao);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Academia
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Endereco = reader.GetString("Endereco"),
                    Telefone = reader.GetString("Telefone")
                });
            }
            return lista;
        }

        public void InserirAluno(Aluno aluno)
        {
            using var conexao = new MySqlConnection(_conexao);
            conexao.Open();
            string query = "INSERT INTO Alunos (Nome, EstaPagando, AcademiaId) VALUES (@nome, @pag, @acad)";
            using var cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@pag", aluno.EstaPagando);
            cmd.Parameters.AddWithValue("@acad", aluno.AcademiaId);
            cmd.ExecuteNonQuery();
        }

        public List<Aluno> ListarAlunos()
        {
            var lista = new List<Aluno>();
            using var conexao = new MySqlConnection(_conexao);
            conexao.Open();
            string query = "SELECT Id, Nome, EstaPagando, AcademiaId FROM Alunos";
            using var cmd = new MySqlCommand(query, conexao);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Aluno
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    EstaPagando = reader.GetBoolean("EstaPagando"),
                    AcademiaId = reader.GetInt32("AcademiaId")
                });
            }
            return lista;
        }
    }
}