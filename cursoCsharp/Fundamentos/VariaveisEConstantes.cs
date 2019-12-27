using System;
using System.Collections.Generic;
using System.Text;

namespace cursoCsharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {

            // area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI= 3.1415
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("area é" + area);
            Console.WriteLine("");
        }
    }
}

