using System;

namespace SistemaDeEmprestimo.Modelos
{
public class ItemEmprestimo
{
    public int Id { get; private set; }
    public Equipamento Equipamento { get; private set; }
    public DateTime? DataDevolucao { get; private set; }


    public ItemEmprestimo(int id, Equipamento equipamento)
    {
        if (id <= 0)
            throw new ArgumentException("O ID deve ser maior que zero.");


        if (equipamento == null)
            throw new ArgumentNullException(nameof(equipamento));


        if (!equipamento.Disponivel)
            throw new InvalidOperationException("O equipamento não está disponível.");


        Id = id;
        Equipamento = equipamento;
        DataDevolucao = null;


        Equipamento.MarcarIndisponivel();
    }


    public void RegistrarDevolucao()
    {
        if (EstaDevolvido())
            throw new InvalidOperationException("Este equipamento já foi devolvido.");


        DataDevolucao = DateTime.Now;
        Equipamento.MarcarDisponivel();
    }


    public bool EstaDevolvido()
    {
        return DataDevolucao.HasValue;
    }
}
}