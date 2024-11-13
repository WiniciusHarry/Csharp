// EStrutura de Repitcao While
Random numeroAleaotrio = new Random();
int numero = numeroAleaotrio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Numero Alvo: {numero}");
// Loop que incrementa o contador ate ele atingir o numero alvo
while (contador < numero)
{
    Console.WriteLine($"Contador: {contador}.");
    contador++;
}
Console.WriteLine($"Contador atingiu o numero alvo: {contador}");

// Estrutura de Repitcao Do While
int numero = 0 

do
{
    Consoleo.WriteLine($"Numero: {numero}");
} while (numero < 10);

// Estrutura de Repitcao For
// for (INICIALIZACAO; CONDICAO; IMPLEMENTO)
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}

Estrutura de Repitcao ForEach
foreach (var item in colecao)
string[] nomes = {"Jacqueline, Bhianca, Harisson"};
foreach (var nome in nomes)
{
    Console.WriteLine(nome)
}

// Exercicios
// 01
int soma = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        soma = soma + i;
    }
    Console.WriteLine("O valor e:" + soma);
}   

// 02
Console.WriteLine("Contagem regressiva:");
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine("Decolaaaaar");

// 03
Console.WriteLine("Escreva uma palavra:");
string? palavra = Console.ReadLine();
string[] vogais = {"a , e, i, o ,u};
int vogal = 0;
foreach (char letra in palavra)
{
    if ("vogais".Contains(letra))
    {
        vogal++;
    }
}
    Console.WriteLine(vogal);

// 04
Console.WriteLine("Escreva uma palavra:");
string? entrada = Console.ReadLine();
string palavra = entrada.ToLower();
Console.WriteLine("Palavra normal: " + entrada);
string textoInvertido = new string(entrada.Reverse().ToArray());
string palavraB = textoInvertido.ToLower();
Console.WriteLine("Palavra invertida: " + textoInvertido);
if (palavra == palavraB)
{
    Console.WriteLine("A palavra e um Palindromo");
}
else
{
    Console.WriteLine("A palavra nao e um Palindromo");
}

// 05
Random random = new Random();
int numeroAleatorio = random.Next(1,101);
int palpite;
int contador = 0;
bool acertou = false;
Console.WriteLine("Tente adivinhar um numero de 1 a 100: " );
while (!acertou)
{
    Console.WriteLine("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());
    if (palpite < numeroAleatorio)
    {
        Console.WriteLine("O numero e maior!");
        contador++;
    }
    else if (palpite > numeroAleatorio)
    {
        Console.WriteLine("O numero e menor!");
        contador++;
    }
    else
    {
        contador++;
        Console.WriteLine($"Parabens! Voce adivinhou o numero sorteado '{numeroAleatorio}' depois de '{contador}' tentativas");
        acertou = true;
    }
}