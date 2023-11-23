
List<(string, int)> pessoasAlturas = new List<(string, int)>
{
    ("João", 175),
    ("Maria", 162),
    ("Brito", 183),
    ("Rafaela", 165),
    ("Cristina", 157)
};

// Expressão lambda para extrair a altura de cada pessoa
Func<(string, int), int> altura = pessoa => pessoa.Item2;

// Calculando a média das alturas usando LINQ
double mediaAlturas = pessoasAlturas.Select(altura).Average();

Console.WriteLine($"Altura média das pessoas: {mediaAlturas} cm");

