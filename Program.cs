using SistemaDeEmprestimo.Modelos;
Usuario usuario = new Usuario(1, "Ana", "ana@email.com");

Console.WriteLine($"ID: {usuario.Id}");
Console.WriteLine($"Nome: {usuario.Nome}");
Console.WriteLine($"E-mail: {usuario.Email}");

usuario.AlterarDados("Ana Silva", "ana.silva@email.com");

Console.WriteLine($"Novo nome: {usuario.Nome}");
Console.WriteLine($"Novo e-mail: {usuario.Email}");
try
{
    Equipamento equipamento = new Equipamento(1, "Projetor");

    equipamento.MarcarIndisponivel();
    Console.WriteLine(equipamento.Disponivel);
}
catch (ArgumentException erro)
{
    Console.WriteLine(erro.Message);
}