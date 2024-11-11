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
