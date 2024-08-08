
#region Estrutura IF - ELSE IF - ELSE

Console.WriteLine ( "Digite a nota:" );

var notaDigitada = Console.ReadLine();

var nota = int.Parse(notaDigitada);

if (nota >= 70)
{
    Console.WriteLine ( "Aprovado." );
}
else if (nota >= 40)
{
    Console.WriteLine ( "Em recuperação." );
}
else
{
    Console.WriteLine ( "Reprovado." );
}

#endregion

#region Estrutura SWITCH CASE

while (true)
{
    Console.Clear ();
    Console.WriteLine ( "Seja bem-vindo a empresa X.\n" );

    Console.WriteLine ( "1 - Contrataação de plano." );
    Console.WriteLine ( "2 - Reclamação de serviço prestado." );
    Console.WriteLine ( "3 - Segunda via de boleto." );
    Console.WriteLine ( "4 - Sair." );

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine ( "\nVocê digitou a opção 1\n" );
            break;
        case "2":
            Console.WriteLine ( "\nVocê digitou a opção 2\n" );
            break;
        case "3":
            Console.WriteLine ( "\nVocê digitou a opção 3\n" );
            break;
        case "4":
            return;
        default:
            Console.WriteLine ( "Opção inválida!" );
            break;
    }
    Console.WriteLine ( "Digite uma tecla para continuar..." );
    Console.ReadLine ();
}

#endregion
