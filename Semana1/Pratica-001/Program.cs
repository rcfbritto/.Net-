#region Questão 4
using System;
class Program {
    static void Main()
    {
        // Variáveis
        int x = 10;
        int y = 3;

        // Adição
        int soma = x + y;
        Console.WriteLine($"Adição: {x} + {y} = {soma}");

        // Subtração
        int subtracao = x - y;
        Console.WriteLine($"Subtração: {x} - {y} = {subtracao}");

        // Multiplicação
        int multiplicacao = x * y;
        Console.WriteLine($"Multiplicação: {x} * {y} = {multiplicacao}");

        // Divisão
        if (y != 0)
        {
            // Verifica se y é diferente de zero para evitar divisão por zero
            double divisao = (double)x / y;
            Console.WriteLine($"Divisão: {x} / {y} = {divisao}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }
}
#endregion

#region Questão 5
using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int a = 5;
        int b = 8;

        // Verifica se a é maior que b
        if (a > b)
        {
            Console.WriteLine($"{a} é maior que {b}.");
        }
        else
        {
            Console.WriteLine($"{a} não é maior que {b}.");
        }
    }
}
// A saída será "5 não é maior que 8." 
#endregion

#region Questão 6
using System;
class Program {
    static void Main()
    {
        // Strings
        string str1 = "Hello";
        string str2 = "World";

        // Verifica se as strings são iguais
        if (str1 == str2)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings não são iguais.");
        }
    }
}
// A saída será "As strings não são iguais."
#endregion

#region Questão 7
using System;
class Program{
    static void Main()
    {
        // Variáveis booleanas
        bool condicao1 = true;
        bool condicao2 = false;

        // Verifica se ambas as condições são verdadeiras
        if (condicao1 && condicao2)
        {
            Console.WriteLine("Ambas as condições são verdadeiras.");
        }
        else
        {
            Console.WriteLine("Pelo menos uma das condições não é verdadeira.");
        }
    }
}
// A saída será "Pelo menos uma das condições não é verdadeira.", porque condicao2 é false, e a condição && exige que ambas as condições sejam verdadeiras para que a expressão geral seja verdadeira.
#endregion

#region Questão 8
using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        // Verifica se num1 é maior que num2
        if (num1 > num2)
        {
            Console.WriteLine($"{num1} é maior que {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} não é maior que {num2}.");
        }

        // Verifica se num3 é igual a num1 + num2
        if (num3 == num1 + num2)
        {
            Console.WriteLine($"{num3} é igual a {num1} + {num2}.");
        }
        else
        {
            Console.WriteLine($"{num3} não é igual a {num1} + {num2}.");
        }
    }
}
// A saída será: 
//"7 é maior que 3.
// 10 é igual a 7 + 3."
//Isso ocorre porque num1 é maior que num2 (7 > 3) e num3 é igual a num1 + num2 (10 = 7 + 3).
#endregion
