namespace SistemaDeEmprestimo.Modelos
{
    public class Equipamento
    {
        public int Id { get; }
        public string Nome { get; private set; }
        public bool Disponivel { get; private set; }

        public Equipamento(int id, string nome)
        {
            if (id <= 0)
                throw new ArgumentException("O identificador deve ser positivo.");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome não pode estar vazio.");

            Id = id;
            Nome = nome.Trim();
            Disponivel = true;
        }

        public void AlterarDados(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
                throw new ArgumentException("O nome não pode estar vazio.");

            Nome = novoNome.Trim();
        }

        public void MarcarIndisponivel()
        {
            Disponivel = false;
        }

        public void MarcarDisponivel()
        {
            Disponivel = true;
        }
    }
}