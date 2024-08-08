using DotNetDiretoAoPonto.ProgramacaoOO;

var professor = new Professor (5000m, "João", "123456", new DateTime(1980, 1, 1));
var estudante = new Estudante ("Luis", "654321", new DateTime(1992, 1, 1), "A");

var pessoas = new List<Pessoa> { estudante, professor };

foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar ( );
}

Console.ReadLine ( );