// Tipos de dados primitivos 

short ano = 2025;

int contador = 10;

long populacaoMundial = 7800000000;

//numeros de ponto flutuante

float temperatura = 46.6f;

double precoproduto = 199.90f;

//tipo caracter

char inicial = "W";

//tipo logicos

bool estalogado = true;
bool ativo = false;


//Tipos de dados nao primitivos 

string saudacao = "Ola Mundo!";

//Arrays  
int[] numeros = {1, 2, 3, 4, 5}
string[] nomes = {"Luara", "Bhianca", "Jacqueline"}

//Classe 
public class Pessoa
{
    public string nome;
    public int idade;
}

//Structs
public class Ponto
{
    public int X;
    public int Y;
}

//Enums,
public enum diaDaSemana
{
    Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
}

//Interfaces
public interface IVeiculo
{
    void Mover();
}

//Delegates
public delegate void Processar(int numero);

//Nullable Types
int? idade =  null;
