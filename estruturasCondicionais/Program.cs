// Estrutura Condicional IF e ELSE
double nota1 = 8.0;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
     Console.WriteLine($"Media {media:F2}: Aprovado");
 }
else
{
     Console.WriteLine($"Media {media:F2}: Recuperacao");
}

// Exemplo Alinhado
double nota1 = 8.0;
double nota2 = 8.0;
double nota3 = 5.0;
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"Media {media:F2}: Aprovado");
}
else if (media >= 5 && media < 7)   
{
     Console.WriteLine($"Media {media:F2}: Recuperacao");
}
 else
{
     Console.WriteLine($"Media {media:F2}: Reprovado");
}

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

// Estrutura Condicional Switch Case

string dia = "Sabado";

switch (dia)
{
    case "Sabado":
        Console.WriteLine("Sabadoooo galera!");
        break;
    case "Domingo":
        Console.WriteLine("Domingao, dia de dormir o dia todo");
        break;
    default:
        Console.WriteLine("Hoje e dia de semana, levanta da cama e para de preguica")
        break;
}

//  Exemplo 2:

Console.WriteLine("Digite uma vogal:");
string? letra = Console.ReadLine();
string letraMinuscula = letra.ToLower();
//string letraMaiuscula = letra.ToUpper();
switch (letraMinuscula)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A letra '{letraMinuscula}' e uma vogal.");
        break;
    default:
        Console.WriteLine($"A letra '{letraMinuscula}' nao e uma vogal.");
        break;
}

// Operador Ternario

int idade = 18
string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);