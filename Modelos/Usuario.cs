namespace SistemaDeEmprestimo.Modelos
{
    public class Usuario
    {
        public int Id { get; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public void AlterarDados(string novoNome, string novoEmail)
        {
            Nome = novoNome;
            Email = novoEmail;
        }
    }
}