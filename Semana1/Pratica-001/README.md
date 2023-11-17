# Instrução Prática 001

## Questão 1
### - Configuração do ambiente:
#### Como você pode verificar se o .NET SDK está corretamente instalado em seu sistema e como verificar as versões do .NET?

Para verificar se o .NET SDK está corretamente instalado é preciso verificar a versão instalada no sistema. Para isso, é preciso abrir o prompt de comando e digitar o comando "dotnet --version". Se o SDK estiver instalado corretamente, será vista a versão do .NET SDK instalada. Caso contrário, é possível instalá-lo, baixando o .NET SDK mais recente no site oficial da Microsoft.

#### Como remover o .NET SDK?
Se por algum motivo for necessário remover uma versão específica do .Net SDK, será necessário utilizar o seguinte comando:
```
dotnet --uninstall-sdks <versão_do_SDK_a_ser_removida>
```
Onde <versão_do_SDK_a_ser_removida> será a versão específica do SDK que deseja desinstalar.

#### Como atualizar o .Net no sistema?
Para atualizar o .NET SDK para a versão mais recente é possível usar o seguinte comando:
```
dotnet --upgrade
```
Não esquecendo de antes de checar a versão instalada com o comando <dotnet --version> e listar as versões do SDK instaladas, usando <dotnet --list-sdks>, para fazer a verificação. 
Uma outra forma seria usar o comando <dotnet new update --check-only> que apenas verifica se existem atualizações.

## Questão 2
### - Tipos de dados:
#### Quais são os tipos de dados numéricos inteiros disponíveis no .NET? Dê exemplos de uso para cada um deles.
No .NET, existem vários tipos de dados numéricos inteiros que podem ser utilizados para armazenar números inteiros sem parte fracionária. 
Vamos ver alguns dos dos principais tipos de dados numéricos inteiros no .NET, juntamente com exemplos de uso em C#:

- byte: Representa inteiros de 8 bits sem sinal, ou seja, valores pequenos e positivos de 0 a 255. 

Exemplo: Verificar se uma pessoa é elegível para votar (idade mínima para votar é 16 anos).
```
byte idade = 20;

if (idade >= 16)
{
    Console.WriteLine("A pessoa é elegível para votar.");
}
else
{
    Console.WriteLine("A pessoa não é elegível para votar.");
}

```
- sbyte: Representa inteiros de 8 bits com sinal, ou seja, valores bem pequenos e que possam ser nagativos ou positivos, de -128 até 127.

Exemplo:  Verificar se a temperatura está abaixo do ponto de congelamento da água em Celsius.
```
sbyte temperaturaAtual = 0;

if (temperaturaAtual < 0)
{
    Console.WriteLine("A água está congelada.");
}
else
{
    Console.WriteLine("A água está em estado líquido.");
}

```

- short: Representa inteiros de 16 bits com sinal. São valores inteiros um pouco maiores, que possam ser negativo, indo de -32.768 até 32.767.

Exemplo: Verificar se há estoque suficiente para processar um pedido.
```
short quantidadeEmEstoque = 100;
short quantidadePedido = 120;

if (quantidadePedido <= quantidadeEmEstoque)
{
    Console.WriteLine("Pedido processado com sucesso");
}
else
{
    Console.WriteLine("Não há estoque suficiente para o pedido.");
}

```
- ushort: Representa inteiros de 16 bits sem sinal, usado para armazenar inteiros um pouco maiores e positivos, de 0 até 65.535.

Exemplo: Controlando o número de itens em um carrinho de compras.
```
ushort itensNoCarrinho = 5;

if (itensNoCarrinho > 0)
{
    Console.WriteLine($"Você tem {itensNoCarrinho} itens no carrinho.");
}
else
{
    Console.WriteLine("Seu carrinho está vazio.");
}

```
- int: Representa inteiros de 32 bits com sinal (o tipo de dados inteiro mais comum). 

Exemplo: Simulando transações bancárias.
```
int saldoBancario = 500;

// Simulação de depósito
int valorDeposito = 200;
saldoBancario += valorDeposito;

Console.WriteLine($"Novo saldo após depósito: {saldoBancario}");

```
- uint: Representa inteiros de 32 bits sem sinal. São usados para armazenar valores inteiros como o int, mas apenas positivos.

Exemplo: Controle de população de uma cidade.
```
uint populacaoCidade = 1000000;

// Simulação de crescimento populacional
uint aumentoPopulacional = 5000;
populacaoCidade += aumentoPopulacional;

Console.WriteLine($"População atual: {populacaoCidade}");

```
- long: Representa inteiros de 64 bits que podem ser nagativos, de -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807.

Exemplo: Convertendo segundos em minutos.
```
long totalSegundos = 150;
long minutos = totalSegundos / 60;

Console.WriteLine($"Total de minutos: {minutos}");

```
- ulong: Representa inteiros de 64 bits sem sinal, positivos, de 0 até 18.446.744.073.709.551.615.

Exemplo: Controle do número de visualizações de um vídeo.
```
ulong visualizacoesVideo = 1000;

// Simulação de novas visualizações
ulong novasVisualizacoes = 500;
visualizacoesVideo += novasVisualizacoes;

Console.WriteLine($"Total de visualizações: {visualizacoesVideo}");

```

## Questão 3
### - Conversão de Tipos de Dados:
#### Suponha que você tenha uma variável do tipo double e deseja convertê-la em um tipo int. Como você faria essa conversão e o que aconteceria se a parte fracionária da variável double não pudesse ser convertida em um int? Resolva o problema através de um exemplo em C#.
Ao converter uma variável do tipo double para int em C#, a parte fracionária será truncada (ou seja, removida), resultando em uma perda de precisão.
Uma forma de fazer essa conversão seria usando a conversão explícita:

```
double numeroDouble = 3.75;
int numeroInteiro = (int)(numeroDouble);
```

A saída para o numeroInteiro após a conversão seria 3.

Se a parte fracionária for significativa, a conversão pode resultar em um valor diferente do esperado, como acontece aqui. Dessa forma, uma alternativa seria converter a variável utilizando a classe Convert e com isso também arredondar o valor na conversão:
```
double numeroDouble = 3.75;
int numeroInteiro = Convert.ToInt32(numeroDouble);
```
Nesse caso, a saída para o numeroInteiro, após a conversão, seria 11. Isso acontece porque o método Convert.ToInt32() arredonda para o número inteiro mais próximo e trata a parte fracionária de maneira apropriada. Se a parte fracionária não puder ser representada como um número inteiro, a conversão truncará a parte decimal.


## Questão 4
### - Operadores Aritméticos:
#### Dada a variável int x = 10 e a variável int y = 3, escreva código para calcular e exibir o resultado da adição, subtração, multiplicação e divisão de x por y.
```
Implementada no arquivo Program.cs   
```

## Questão 5
### - Operadores de Comparação:
#### Considere as variáveis int a = 5 e int b = 8. Escreva código para determinar se a é maior que b e exiba o resultado.
```
Implementada no arquivo Program.cs 
```

## Questão 6
### - Operadores de Igualdade:
#### Você tem duas strings, string str1 = "Hello" e string str2 = "World". Escreva código para verificar se as duas strings são iguais e exibir o resultado.
```
Implementada no arquivo Program.cs 
```

## Questão 7
### - Operadores Lógicos:
#### Suponha que você tenha duas variáveis booleanas, bool condicao1 = true e bool condicao2 = false. Escreva código para verificar se ambas as condições são verdadeiras e exiba o resultado.
```
Implementada no arquivo Program.cs 
```

## Questão 8
### Desafio de Mistura de Operadores:
#### Dadas as variáveis int num1 = 7, int num2 = 3, e int num3 = 10, escreva código para verificar se num1 é maior do que num2 e se num3 é igual a num1 + num2.
```
Implementada no arquivo Program.cs 
```
