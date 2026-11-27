using SistemaDeEmprestimo.Modelos;

namespace SistemaDeEmprestimo.Service
{
    public class EmprestimoServico
    {
        private readonly UsuarioServico usuarioServico;
        private readonly EquipamentoServico equipamentoServico;
        private readonly List<Emprestimo> emprestimos = new();

        public EmprestimoServico(
            UsuarioServico usuarioServico,
            EquipamentoServico equipamentoServico)
        {
            this.usuarioServico = usuarioServico;
            this.equipamentoServico = equipamentoServico;
        }

        public Emprestimo RealizarEmprestimo(
            int usuarioId,
            IReadOnlyCollection<int> equipamentoIds)
        {
            throw new NotImplementedException();
        }

        public void RegistrarDevolucao(
            int emprestimoId,
            int equipamentoId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Emprestimo> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Emprestimo> ListarFinalizados()
        {
            throw new NotImplementedException();
        }

        public Emprestimo? ConsultarPorId(int emprestimoId)
        {
            throw new NotImplementedException();
        }
    }
}