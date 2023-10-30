using Bucle2.Servicios;
using System.ComponentModel.Design;

namespace Bucle2;

/// <summary>
/// Class program donde se encontrará el método Main
/// 301023 - chi
/// </summary>
class Program
{
    /// <summary>
    /// Main del programa donde se llamarán a los métodos
    /// 301023 - chi
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        
        MenuInterfaz a = new MenuImplementacion(); //Creo una copia del menú Implementación
 
        
        int b = a.num2(); /*Int*/
        double c = a.num1(); /*Double*/

        Console.WriteLine(b);
        Console.WriteLine(c);

        for (int d = 1; d <=b; ++d) //Bucle por el que el double se elevará por el int 
        {
            double resultado = c * c;
            Console.WriteLine(resultado);
        }
    }
}

