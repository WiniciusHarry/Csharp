// Exemplo
string nome = "Harry"
string saudacao = "Ola," + nome + "!Bem Vindo."; 
Console.WriteLine(saudacao);

// Interpolacao de string
string nome = "Harry"
string saudacao = $"Ola, {nome} !Bem Vindo."; 
Console.WriteLine(saudacao);

// Operador GetType()
int numero = 5;
Console.WriteLine(numero.GetType());

// Palavra-chave typeof
Console.WriteLine(typeof(int));

// Metodo Parse (apenas conversao de string para um tipo)
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:" + valorTexto.GetType());

int numero = int.Parse(valorTexto);
Console.WriteLine("A variavel numeroParse e do tipo:" + valorTexto.GetType());

// Metodo Convert: Cast/Casting (Conversao de um numero do tipo string para int, float ou double usando Convert)
string valorEmTexto = "100"
Console.WriteLine("Valor da variavel string: " + valorEmTexto);
Console.WriteLine("A variavel valorTexto e do tipo:" + valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.Write(numeroConvertido);
Console.WriteLine("Apos concersao a variavel numeroConvertido e do tipo: " + numeroConvertido.GetType());

// Metodo ToString (converte qualquer tipo para string)
// Uso 1:
int numero = 123
Console.WriteLine(numero.GetType());

string numeroComoString = numero.ToString();
Console.WriteLine(numeroComoString.GetType());
// Uso 2 
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataformatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataformatada);

string dataHoraFormatada = dataAtual.ToString("HH:mm:ss");
Console.WriteLine(dataHoraFormatada);
// Uso 3
double preco = 29.99;
Console.WriteLine($"O preco e: {preco.ToString("C2")}");
// Uso 4
decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new system.globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new system.globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorBR);