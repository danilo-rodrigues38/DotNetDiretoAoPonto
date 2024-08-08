using System;

namespace DotNetDiretoAoPonto.ProgramacaoOO
{
    public class Professor : Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento) : base (nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B" };
        }

        public List<string> Turmas { get; private set; }
        public decimal Salario { get; set; }

        public override void SeApresentar ( )
        {
            base.SeApresentar ( );

            var turmas = string.Join ( ", ", Turmas );

            Console.WriteLine ( $"Sou professor." );
            Console.WriteLine ( $"Meu salário é R$ {Salario}." );
            Console.WriteLine ( $"E ensino para as turmas {turmas}." );
        }
    }
}
