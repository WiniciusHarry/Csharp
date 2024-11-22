// 01 
using System;
namespace classes.veiculo
{
    public class veiculo
    {
        string marca;
        string modelo;
        int ano;

        public veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }
        
        public void Acelerar()
        {
            Console.WriteLine($"{marca} esta acelerando.");
        }
        public void Freiar()
        {
            Console.WriteLine($"{marca} esta freiando.");
        }
    }
}