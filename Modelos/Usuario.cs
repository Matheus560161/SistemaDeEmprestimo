
namespace SistemaDeEmprestimo.Modelos
{
    public class Usuario
    {
        public int Id { get; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(int id, string nome, string email)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID inválido.");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome inválido.");
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("E-mail inválido.");
            }

            Id = id;
            Nome = nome;
            Email = email;
        }

        public void AlterarDados(string novoNome, string novoEmail)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
            {
                throw new ArgumentException("Nome inválido.");
            }

            if (string.IsNullOrWhiteSpace(novoEmail) || !novoEmail.Contains("@") || !novoEmail.Contains("."))
            {
                throw new ArgumentException("E-mail inválido.");
            }

            Nome = novoNome;
            Email = novoEmail;
        }
    }
}
