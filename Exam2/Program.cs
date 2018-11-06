using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new int[] {44, 55, 12, 42, 94, 18, 6};
            for (var i = 1; i < valores.Length; i++)
            {
                for (var j = 0; j < valores.Length - i; j++)
                {
                    if (valores[j] <= valores[j + 1]) continue;
                    var auxiliar = valores[j];
                    valores[j] = valores[j + 1];
                    valores[j + 1] = auxiliar;
                    //Mostramos como van cambiando los valores en cada iteracion
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",valores[0], valores[1], valores[2],
                        valores[3], valores[4], valores[5], valores[6]);
                }
            }

            foreach (var valor in valores)
            {
                Console.WriteLine(valor);
            }
            Console.Read();
        }
    }
}
