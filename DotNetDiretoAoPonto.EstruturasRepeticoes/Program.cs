#region Estrutura de Repetição FOR

Console.WriteLine ( "*** Usando for: ***\n" );

Console.WriteLine ( "Digite uma sequência de números separados por espaço." );
// Ex: 0 1 2 3 4 5 6 7 8 9

var numerosTexto = Console.ReadLine ( );

var numeros = numerosTexto.Split (' ');

Console.WriteLine ( "Números: " );

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine ( numeros [ i ] );
}

#endregion

#region Estrutura de Repetição WHILE

Console.WriteLine ( "\n*** Usando while: ***\n" );

var contador = 0;

Console.WriteLine ( "Números: " );

while ( contador < numeros.Length )
{
    Console.WriteLine( numeros [contador] );

    contador++;
}

#endregion

#region Estrutura de Repetição FOREACH

Console.WriteLine ( "\n*** Usando foreach: ***\n" );

Console.WriteLine ( "Números: " );

foreach (var numero in numeros)
{
    Console.WriteLine ( numero );
}

#endregion

Console.ReadKey();