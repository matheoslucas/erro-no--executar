﻿using System;
using System.Collections.Generic;
namespace CursoCSharp
{
    class PrimeiroPrograma
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                               {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar }

            });

            central.SelecionarEExecutar();
        }
    }
}