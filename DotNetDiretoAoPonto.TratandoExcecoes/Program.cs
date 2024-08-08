#region Tratando Exceções

var setString = "sete";
string valorNull = null;
var longValue = long.MaxValue.ToString ( );

try
{
    var formatException = int.Parse ( setString );
    //var argumentNullException = int.Parse ( valorNull );
    //var overflowException = int.Parse ( longValue );
}
catch (FormatException ex)
{
    Console.WriteLine ( $"Format exception: {ex.Message}" );
    Console.WriteLine ( ex );
}
catch (ArgumentException ex)
{
    Console.WriteLine ( $"Argument exception: {ex.Message}" );
}
catch (OverflowException ex)
{
    Console.WriteLine ( $"Overflow exception: {ex.Message}" );
}
finally
{
    Console.WriteLine ( "Este código sempre é executado." );
}

#endregion
