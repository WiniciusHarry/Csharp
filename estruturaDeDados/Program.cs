// // Exemplo Vetor (Array)
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;
// Console.WriteLine("Numero no array: ");
// for (int i = 0; i < meuArray.Length; i++)
// {
//     Console.WriteLine(meuArray[i]);
// }

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
for (int i - 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
