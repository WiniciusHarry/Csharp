// double nota1 = 8.0;
// double nota2 = 8.0;
// double nota3 = 6.8;
// double media = (nota1 + nota2 + nota3) / 3;
// if (media >= 7)
// {
//     Console.WriteLine($"Media {media:F2}: Aprovado");
// }
// else
// {
//     Console.WriteLine($"Media {media:F2}: Recuperacao");
// }

// // Exemplo Alinhado
// double nota1 = 8.0;
// double nota2 = 8.0;
// double nota3 = 5.0;
// double media = (nota1 + nota2 + nota3) / 3;
// if (media >= 7)
// {
//     Console.WriteLine($"Media {media:F2}: Aprovado");
// }
// else if (media >= 5 && media < 7)   
// {
//     Console.WriteLine($"Media {media:F2}: Recuperacao");
// }
// else
// {
//     Console.WriteLine($"Media {media:F2}: Reprovado");
// }

//Exemplo if, else e else if e operador logico
Console.WriteLine("Digite uma vogal");
string? letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if(letra == "e" || letra == "E")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if(letra == "i" || letra == "I")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if(letra == "o" || letra == "O")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if(letra == "u" || letra == "U")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else
{
    Console.WriteLine($"A letra {letra} nao e uma vogal");
}