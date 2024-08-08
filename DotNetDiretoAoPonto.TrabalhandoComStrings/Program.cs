#region Prinncipais Métodos, Campo e Propriedade

//var frase = "      C# é uma linguagem moderna e versátil. " +
//    "Com C# consigo desenvolver pra Web, Desktop, Jogos, " +
//    "Mobile, entre outros.      ";

//// Length
//var fraseLength = frase.Length;

//// Empty
//var fraseEmpty = string.Empty;

//// ToLowwer, ToUpper
//var fraseToLower = frase.ToLower();
//var fraseToUpper = frase.ToUpper();

//// Split
//var fraseSplit = frase.Split('.');

//// Trim, TrimEnd, TrimStart
//var fraseTrim = frase.Trim();
//var fraseTrimEnd  = frase.TrimEnd();
//var fraseTrimStart  = frase.TrimStart();

//// IsNullOrWhiteSpace
//var fraseIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(frase);

//// Replace
//var fraseReplace = frase.Replace("C#", "C-Sharp");

#endregion

#region Busca

var outraFrase = "C# é uma linguagem moderna e versátil. " +
    "Com C# consigo desenvolver pra Web, Desktop, Jogos, " +
    "Mobile, entre outros.";

// IndexOf
var outraFraseIndexOf = outraFrase.IndexOf("C#");

// LastIndexOf
var outraFraseLastIndexOf = outraFrase.LastIndexOf("C#");

// StartsWith
var outraFraseStartsWith = outraFrase.StartsWith("C#");

// Substring
var indexOFMobile = outraFrase.IndexOf("Mobile");
var SubstringMobile = outraFrase.Substring(indexOFMobile, 6);

// Contains
var containsJogos = outraFrase.Contains("jogos", StringComparison.OrdinalIgnoreCase);
var containsJogosminusculo = outraFrase.Contains("jogos");
var containsJogosExact = outraFrase.Contains("Jogos");
var containsRuim = outraFrase.Contains("ruim");

#endregion

Console.ReadKey();