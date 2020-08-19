using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pueba
{
    class Convercion
    {
        //Arreglos que manejan las unidades de medidas y que permiten hacer las convinaciones
        /*
         * se deja en null por que simboliza las combinación
         * por ejemplo en el caso de las centenas los null que se 
         * encuentran en el arreglo, es por la convinacion que se hace con ciento,
         * que puede ser docientos,trecientos,cuatrocientos, etc.
         * e igual con los demas arreglos
         */

      string[] unidades = { null, "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] diez_y = { null, "once", "doce", "trece", "catorce", "quince" };
      string[] decimas = { null, "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
      string[] centenas = { null, "ciento", null, null, null, "quinientos", null, "setecientos", null, "novecientos" };


        /*primer metodo que permite convinar las unidades*/
        /*Se utiliza variables del tipo Long
        por que tiene mayor capacidad al momento que el 
        usario desee ingresar un numero de una sifra exorbitante*/
        private void unidadesEnletra(long cantidad)
        {
            //se hace un Casting para manejar cifras pequeñas
            /*operaciones que nos permiten sacar el numero para poder convinarlo*/
            byte unidad = (byte)(cantidad % 10);
            byte decima = (byte)((cantidad / 10) % 10);
            byte centena = (byte)((cantidad / 100) % 10);

            /*condiciones  para poder convinar el numero ingresadod
             comparanado segun su valor con los arreglos*/
            if (centena != 0)
            {
                if (centenas[centena] == null)
                    Console.Write(unidades[centena] + "cientos");

                else if (centena != 1 || unidad != 0 || decima != 0)
                    Console.Write(centenas[centena]);

                else
                    Console.Write("cien");
            }

            if (unidad != 0 || decima != 0)
            {
                if (centena != 0)
                {
                    Console.Write(" ");
                }
                if (decima == 0)
                {
                    Console.WriteLine(unidades[unidad]);
                }
                else if (unidad == 0)
                {
                    Console.Write(decimas[decima]);
                }
                else if (decima == 1 && unidad >= 1 && unidad <= 5)
                {
                    Console.Write(diez_y[unidad]);
                }
                else if (decima == 1)
                {
                    Console.Write("dieci" + unidades[unidad]);
                }
                else if (decima == 2)
                {
                    Console.Write("veinti" + unidades[unidad]);
                }
                else
                {
                    Console.Write(decimas[decima] + " y " + unidades[unidad]);
                }
            }
        }

        /*
         * en este metodo ya no es nesesario hacer un casting 
         * por que ya se manejan cifras mas grandes
         */
       private void millaresEnLetra(long cantidad)
        {
            long unidades = cantidad % 1000;
            long miles = (cantidad / 1000) % 1000;

            if (miles > 1)
            {
                //usamos el metedo de las unidades para mas convinaciones
                unidadesEnletra(miles);
            }
            if (miles != 0)
            {
                Console.Write("mil");
            }
            if (unidades != 0 && miles != 0)
            {
                Console.Write(" ");
            }
            unidadesEnletra(unidades);
        }

        //ULtimo mentodo y el que mandamos a llamar en el main 
        //ya que esta convinado con los demas metodos 
        //y esto nos permite hacer todas las convinaciones posibles
        public void millonesEnLetra(long cantidad)
        {
            //se puede utilizar una de las cifras mas grandes 
            long unidades = cantidad % 1000000L;
            long millares = (cantidad / 1000000L) % 1000000L;

            if (millares > 1)
            {
                millaresEnLetra(millares);
                Console.Write("millones");
            }
            else if (millares != 0)
            {
                //\u00f3 nos permite usar caracteres especial 
                Console.Write("un mill\u00f3n");
            }
            if (unidades != 0 && millares != 0)
            {
                Console.Write(" ");
            }
            millaresEnLetra(unidades);
        }
    }
 
}
