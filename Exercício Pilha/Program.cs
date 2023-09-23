using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Pilha
{
    class Program
    {
        // push e  POP
        static Stack<string> pilha = new Stack<string>();
        static Stack<string> pilha2 = new Stack<string>();

        static void insereNaPilha(string elemento, Stack<string> p)
        {
            p.Push(elemento);
        }
        // +/4*-2753 = 9,25
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            Console.Write("Informe a expressão na formatação polonesa reversa: ");
            string expressao = Console.ReadLine();

            for(int i = 0; i < expressao.Length; i++)
            {
                insereNaPilha(expressao[i].ToString(), pilha);
            }

            foreach(string p in pilha)
            {
                switch(p)
                {
                    case "+":
                        num1 = double.Parse(pilha2.Pop());
                        num2 = double.Parse(pilha2.Pop());
                        resultado = num2 + num1;
                        insereNaPilha(resultado.ToString(), pilha2);
                        break;
                    case "-":
                        num1 = double.Parse(pilha2.Pop());
                        num2 = double.Parse(pilha2.Pop());
                        resultado = num2 - num1;
                        insereNaPilha(resultado.ToString(), pilha2);
                        break;
                    case "*":
                        num1 = double.Parse(pilha2.Pop());
                        num2 = double.Parse(pilha2.Pop());
                        resultado = num2 * num1;
                        insereNaPilha(resultado.ToString(), pilha2);
                        break;
                    case "/":
                        num1 = double.Parse(pilha2.Pop());
                        num2 = double.Parse(pilha2.Pop());
                        double aux = num2 / num1;
                        insereNaPilha(aux.ToString(), pilha2);
                        break;
                    default:
                        insereNaPilha(p, pilha2);
                        break;
                }

            }


            Console.WriteLine($"Resultado: { pilha2.Pop() }");
            Console.ReadKey();
        }
    }
}
