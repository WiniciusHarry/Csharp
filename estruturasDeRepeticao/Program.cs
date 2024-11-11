// // EStrutura de Repitcao While
// Random numeroAleaotrio = new Random();
// int numero = numeroAleaotrio.Next(1, 101);
// int contador = 0;
// Console.WriteLine($"Numero Alvo: {numero}");
// // Loop que incrementa o contador ate ele atingir o numero alvo
// while (contador < numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o numero alvo: {contador}");

// // Estrutura de Repitcao Do While
// int numero = 0 

// do
// {
//     Consoleo.WriteLine($"Numero: {numero}");
// } while (numero < 10);

// // Estrutura de Repitcao For
// // for (INICIALIZACAO; CONDICAO; IMPLEMENTO)
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }

// // Estrutura de Repitcao ForEach
// // foreach (var item in colecao)
// string[] nomes = {"Jacqueline, Bhianca, Harisson"};
// foreach (var nome in nomes)
// {
//     Console.WriteLine(nome)
// }

// // Exercicios
// // 01
// int soma = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         soma = soma + i;
//     }
//     Console.WriteLine("O valor e:" + soma);
// }   

// // 02
// Console.WriteLine("Contagem regressiva:");
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine($"{i}");
// }
// Console.WriteLine("Decolaaaaar");

// 03
string[] vogais = {"a", "e", "i", "o", "u"};
Console.WriteLine("Digite uma palavra:");
string? palavra = Console.ReadLine();
string palavra = palavra.ToLower();
switch (palavra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A palavra '{palavra}' possui uma vogal.");
        break;
    default:
        Console.WriteLine($"A palavra '{palavra}' nao possui uma vogal.");
        break;
}