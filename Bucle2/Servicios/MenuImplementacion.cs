using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle2.Servicios
{
    /// <summary>
    /// Clase donde se encuentran las clases creadas en el menú interfaz
    /// 301023 - chi
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz //Conecto los servicios
    {
        /// <summary>
        ///Int creado en el Menu Interfaz
        /// 301023 - chi
        /// </summary>
        /// <returns></returns>
        public int num2() 
        {
            int numero2; //Creo un int donde se guardará el numero pedido
            Console.WriteLine("Dame un numero al que quieras elevar");
            numero2 = Convert.ToInt32(Console.ReadLine()); //Lo convierto en un int de 32 bits
            return numero2;
        }

        /// <summary>
        /// Double creado en el Menu Interfaz
        /// 301023 - chi
        /// </summary>
        /// <returns></returns>
        public double num1()
        {
            double numero1; //Creo un double donde se guardará el número pedido
            Console.WriteLine("Dame un numero que quieres que sea elevado");
            numero1 = Convert.ToDouble(Console.ReadLine()); 
            return numero1;
        }

       
    }
}
