using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CALCULADORA.contas
{
    public class BASE
    {
        char adicao;
        char subtracao;
        char multiplicacao;
        char divisao;
        double numero1
        double numero2
    
    public BASE(char adicao,  char subtracao, char multiplicacao, char divisao, double numero1, double numero2)
    {
        this.adicao = +;
        this.subtracao = -;
        this.multiplicacao = *;
        this.divisao = /;
        this.numero1 = numero1;
        this.numero2  = numero2;
    }
    public void operador(double incremento)
    {
        if operador == adicao
        {
            Resultado = numero1 + numero2;
            Console.WriteLine($"O resultado e: {Resultado}");
        }
        else operador == subtracao
        {
            Resultado = numero1 - numero2;
            Console.WriteLine($"O resultado e: {Resultado}");
        }
        else operador == multiplicacao
        {
            Resultado = numero1 * numero2;
            Console.WriteLine($"O resultado e: {Resultado}");
        }
        else operador == divisao
        {
            Resultado = numero1 / numero2;
            Console.WriteLine($"O resultado e: {Resultado}");
        }
    }
    }
}