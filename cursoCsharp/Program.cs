using System;
using System.Collections.Generic;
namespace CursoCSharp
{
    class PrimeiroPrograma
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                { "Primeiro Programa - Fundamentos",() => Console.WriteLine("olá")
                  },
                {"comentarios - Fundamentos",() => Console.WriteLine("") },
                {"variaveis e constantes",() => Console.WriteLine("")
                 }
             });

            central.SelecionarEExecutar();
        }
    }
}