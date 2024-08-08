namespace DotNetDiretoAoPonto.ProgramacaoOO
{
    public class Estudante : Pessoa
    {
        public Estudante(string nome, string documento, DateTime datanascimento, string turma)
            : base (nome, documento, datanascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 6 };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar ( )
        {
            base.SeApresentar ( );

            var media = Notas.Average();

            Console.WriteLine ( $"Sou um estudante da turma {Turma}, minha média de nota é {media}." );
            Console.WriteLine ( );
        }
    }
}
