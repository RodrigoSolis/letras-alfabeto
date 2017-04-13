using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letras
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int total = 0;

            Console.Write ("Ingresa una oración: ");
            cadena = Console.ReadLine();

            if(cadena.Length < 26)
            {
                Console.WriteLine("No están todas las letras del alfabeto");
            }else
            {
                char[] letras = Enumerable.Range('A', 26).Select(i => (char)i).ToArray();
                cadena = cadena.ToUpper();
                char[] mensaje = cadena.ToCharArray();
                for(int i=0; i<letras.Length; i++)
                {
                    char letra = letras[i];
                    int aux = 0;
                    bool bandera = false;
                    while(!bandera && aux < mensaje.Length)
                    {
                        if (letra == mensaje[aux])
                        {
                            total++;
                            bandera = true;
                        }
                        aux++;
                    }
                }
                if (total < 26)
                    Console.WriteLine("No están todas las letras del alfabeto");
                else
                    Console.WriteLine("Si están todas las letras del alfabeto");
            }
            Console.ReadKey();
        }
    }
}
