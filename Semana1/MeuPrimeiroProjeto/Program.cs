// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Teste de Tipos de Dados
    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;

    tipoInteiro = int.MaxValue;
    tipoLong = long.MaxValue;

    tipoString = "100A";
    tipoInteiro = int.TryParse(tipoString);

    System.Console.WriteLine("O máximo inteiro é " +tipoInteiro);
    System.Console.WriteLine("O máximo long é " +tipoLong);

#endregion

#region Operadores
    tipoDouble = tipoInteiro + tipoLong;


    tipoInteiro = 10 > 5 ? 1 : 0;
#endregion