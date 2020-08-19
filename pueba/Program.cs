using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pueba
{
    class Program
    {
        static void Main(string[] args)
        {
           //para poder visualizar el codigo ASCII
            Console.Title = "ASCII Art";
            string title =

                @"  ____     _____    __  __   __  __   ____     ____     ______   
                  /\  _`\  /\  __`\ /\ \/\ \ /\ \/\ \ /\  _`\  /\  _`\  /\__  _\  
                  \ \ \/\_\\ \ \/\ \\ \ `\\ \\ \ \ \ \\ \ \L\_\\ \ \L\ \\/_/\ \/  
                   \ \ \/_/_\ \ \ \ \\ \ , ` \\ \ \ \ \\ \  _\L \ \ ,  /   \ \ \  
                    \ \ \L\ \\ \ \_\ \\ \ \`\ \\ \ \_/ \\ \ \L\ \\ \ \\ \   \ \ \ 
                     \ \____/ \ \_____\\ \_\ \_\\ `\___/ \ \____/ \ \_\ \_\  \ \_\
                      \/___/   \/_____/ \/_/\/_/ `\/__/   \/___/   \/_/\/ /   \/_/
                                                                                  
                                                                                  
                      __  __   __  __             ____     ____     ____       
                     /\ \/\ \ /\ \/\ \   /'\_/`\ /\  _`\  /\  _`\  /\  _`\     
                     \ \ `\\ \\ \ \ \ \ /\      \\ \ \L\ \\ \ \L\_\\ \ \L\ \   
                      \ \ , ` \\ \ \ \ \\ \ \__\ \\ \  _ <'\ \  _\L \ \ ,  /   
                       \ \ \`\ \\ \ \_\ \\ \ \_/\ \\ \ \L\ \\ \ \L\ \\ \ \\ \  
                        \ \_\ \_\\ \_____\\ \_\\ \_\\ \____/ \ \____/ \ \_\ \_\
                         \/_/\/_/ \/_____/ \/_/ \/_/ \/___/   \/___/   \/_/\/ /
                                                                               ";

            Console.WriteLine(title);


           
            Convercion numeros = new Convercion();

            //le pedimos el numero que desea ingresar el Usuario
            Console.Write("Ingrese una Cantidad : ");
            long cantidad = long.Parse(Console.ReadLine());

            //condiciones nesesarias en el caso que el numero sea 0
            if (cantidad < 0)
            {
                Console.WriteLine("menos ");
                cantidad = -cantidad;
            }
            if (cantidad == 0)
            {
                Console.WriteLine("cero");
            }
            else
            {
                //le pasamos el numero obtendio al metodo de la clase Conversion
                numeros.millonesEnLetra(cantidad);
            }
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();

        }


 
    }
}
