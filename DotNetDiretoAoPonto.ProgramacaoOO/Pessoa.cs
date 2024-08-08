namespace DotNetDiretoAoPonto.ProgramacaoOO
{
    public abstract class Pessoa
    {
        public Pessoa ( string nome, string documento, DateTime dataNascimento )
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public virtual void SeApresentar ( )
        {
            Console.WriteLine ( $"Olá, meu nome é {Nome}." );
            Console.WriteLine ( $"O meu documento é {Documento}." );
            Console.WriteLine ( $"Nascido em {DataNascimento}." );
            Console.WriteLine ( );
        }
    }
}
