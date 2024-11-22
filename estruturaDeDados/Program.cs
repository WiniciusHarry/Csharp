// Exemplo Vetor (Array)
int[] meuArray = new int[5];
meuArray[0] = 10;
meuArray[1] = 20;
meuArray[2] = 30;
meuArray[3] = 40;
meuArray[4] = 50;
Console.WriteLine("Numero no array: ");
for (int i = 0; i < meuArray.Length; i++)
{
    Console.WriteLine(meuArray[i]);
}

// Exemplo Lista (List)
// 01
List<string> listaDeNomes = new List<string> {"Luara", "BHianca", "Jacqueline"};
listaDeNomes.Add("Celia");
Console.WriteLine("Nomes na lista: ");
for (int i = 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
// 02
Console.WriteLine("\nVerificacao de existencia do nome Luara: ");
string nomePraVerificar = "Luara";
if (listaDeNomes.Contains(nomePraVerificar))
{
    Console.WriteLine($"{nomePraVerificar} esta na lista");
}
else
{
    Console.WriteLine($"{nomePraVerificar} nao esta na lista");
}
// 03
Console.WriteLine($"\nApos remover Jacqeline: ");
string nomePraRemover = "Jacqueline";
bool foiRemovido = listaDeNomes.Remove(nomePraRemover);
if (foiRemovido)
{
    Console.WriteLine($"{nomePraRemover} foi removido da lista. ");
}
else
{
    Console.WriteLine($"{nomePraRemover} nao foi encontrado na lista. ");
}
// 05
Console.WriteLine("\nApos a remocao: ");
Console.WriteLine("\nNomes na lista após a remoção:");
for (int i - 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}

// Exemplo 03: Conjunto (Set)
Conjunto (Set) os elementos são únicos, ou seja, não permite inserir elementos repetidos no conjunto.
HashSet<int> conjunto = new HashSet<int> { 1, 2, 3 };
conjunto.Add(4);
conjunto.Add(2);

Console.WriteLine("Elementos do Conjunto:");
foreach (int elemento in conjunto)
{
    Console.WriteLine(elemento);
}


HashSet<string> frutas = new HashSet<string> { "Maçã", "Abacaxi", "Laranja" };
frutas.Add("Uva");
frutas.Add("Maçã");

Console.WriteLine("Frutas no conjunto:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.WriteLine("\nVerificação de existência:");
Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não está no conjunto");


frutas.Remove("Laranja");
Console.WriteLine("\nApós remover Laranja:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

HashSet<string> frutas = new HashSet<string> { "Maçã", "Abacaxi", "Laranja" };
frutas.Add("Uva");
frutas.Add("Maçã"); // Não será adicionado novamente, pois HashSet não permite duplicatas.

Console.WriteLine("Frutas no conjunto:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.WriteLine("\nVerificação de existência:");
Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não está no conjunto");

// Solicitar ao usuário a fruta a ser removida
Console.Write("\nDigite o nome da fruta que deseja remover: ");
string? frutaParaRemover = Console.ReadLine();

// Verifica se a fruta existe no conjunto (ignorando maiúsculas/minúsculas)
bool frutaRemovida = false;
foreach (string fruta in frutas)
{
    if (fruta.Equals(frutaParaRemover, StringComparison.OrdinalIgnoreCase))
    {
        frutas.Remove(fruta); // Remove a fruta encontrada
        frutaRemovida = true;
        break;
    }
}

// Exibir o resultado após tentativa de remoção
if (frutaRemovida)
{
    Console.WriteLine($"\n'{frutaParaRemover}' foi removida do conjunto.");
}
else
{
    Console.WriteLine($"\n'{frutaParaRemover}' não foi encontrada no conjunto.");
}

Console.WriteLine("\nFrutas no conjunto após remoção:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

// Exercícios
// Exercício 1: Soma de Elementos no Array
// Enunciado: Dado um array de inteiros int[] numeros = { 1, 2, 3, 4, 5 };, escreva um código que some todos os elementos do array e exiba o resultado no console.
int[] numeros = { 1, 2, 3, 4, 5 };
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos é: {soma}");


// Exercício 2: Contar Ocorrências em uma Lista
// Enunciado: Dada uma lista de strings List<string> nomes = new List<string> { "Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };, escreva um código para contar quantas vezes o nome "Jeane" aparece na lista.
List<string> nomes = new List<string> { "Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };
int contador = 0;

foreach (string nome in nomes)
{
    if (nome == "Jeane")
    {
        contador++;
    }
}

Console.WriteLine($"O nome 'Jeane' aparece {contador} vezes na lista.");


// Exercício 3: Remover Elementos Duplicados com HashSet
// Enunciado: Dada uma lista de inteiros com elementos duplicados List<int> numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5 };, escreva um código para remover os elementos duplicados e exibir a lista sem duplicatas.
List<int> litaDeNumeros = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
HashSet<int> conjunto = new HashSet<int>(litaDeNumeros);

Console.WriteLine("Lista sem duplicatas:");
foreach (int numero in conjunto)
{
    Console.WriteLine(numero);
}


//Exercício 4: Verificar Elemento em um Conjunto
//Enunciado: Dado um conjunto HashSet<string> frutas = new HashSet<string> { "Maçã", "Banana", "Laranja" };, escreva um código que verifique se "Banana" está no conjunto e exiba uma mensagem no console.
HashSet<string> frutas = new HashSet<string> { "Maçã", "Banana", "Laranja" };

if (frutas.Contains("Banana"))
{
    Console.WriteLine("Banana está no conjunto.");
}
else
{
    Console.WriteLine("Banana não está no conjunto.");
}


//Exercício 5: Adicionar Elementos ao Final de uma Lista
//Enunciado: Crie uma lista vazia de números inteiros List<int> numeros = new List<int>();. Em seguida, adicione os números de 1 a 5 na lista e exiba os elementos no console.
List<int> listaDeNumerosVazia = new List<int>();

for (int i = 1; i <= 5; i++)
{
    listaDeNumerosVazia.Add(i);
}

Console.WriteLine("Elementos na lista:");
foreach (int numero in listaDeNumerosVazia)
{
    Console.WriteLine(numero);
}