using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadArreglos
{
    internal class main
    {
        static void Main(string[] args)
        {
            //PUNTO 1
            /*string[] name = new string[4];
            double[] examenparcial = new double[4];
            double[] examenOral = new double[4];
            double[] examenFinal = new double[4];
            int i;
            for (i = 0; i < name.Length|| i<examenparcial.Length||i<examenOral.Length||i<examenFinal.Length; i++)
            {
                Console.WriteLine("Ingrese nombre");
                name[i] = Console.ReadLine();
                Console.WriteLine("Ingrese nota del examen parcial");
                examenparcial[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota del examen oral");
                examenOral[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota del examen Final");
                examenFinal[i] = double.Parse(Console.ReadLine());
                double resultado1 = examenFinal[i] + examenOral[i] + examenparcial[i];
                double resultado = resultado1 / 3;

                if (resultado >= 7)
                {
                    Console.WriteLine("APROBADO con promedio: " + resultado);
                }
                else
                {
                    Console.WriteLine("DESAPROBADO con promedio: " + resultado);
                }

                
            }*/

            //PUNTO 2 
            /*string[] nombres = new string[5];
            string[] apellidos = new string[5];
            int[] edad = new int[5];
            string[] sexo = new string[5];

            for (int f = 0; f < nombres.Length || f < apellidos.Length || f < edad.Length || f < sexo.Length; f++)

            {
                Console.WriteLine("Ingrese nombre");
                nombres[f] = Console.ReadLine();
                Console.WriteLine("Ingrese apellido");
                apellidos[f] = Console.ReadLine();
                Console.WriteLine("Ingrese edad");
                edad[f] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese sexo");
                sexo[f] = Console.ReadLine();


                Console.WriteLine("\nDatos de cliente:");
                Console.WriteLine("Nombre " + nombres[f]);
                Console.WriteLine("Apellido " + apellidos[f]);
                Console.WriteLine("Edad " + edad[f]);
                Console.WriteLine("Sexo " + sexo[f]);
                Console.WriteLine("");
                Console.ReadKey();

            }*/

            //PUNTO 3
            int cantidad;
            int dato;
            int n=0;
            double precio = 0;
            double suma = 0;
            
            string name;
            Console.WriteLine("Bienvenido\n¿Con cuantos productos desea realizar la operacion?");
            dato = int.Parse(Console.ReadLine());
            cantidad = Convert.ToInt32(dato);
            for(n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese nombre del producto");
                name = Console.ReadLine();
                Console.WriteLine("Ingrese precio");
                precio = Convert.ToDouble(Console.ReadLine());
                suma = suma + precio;

            }
            Console.WriteLine("Suma total de los precios de los productos: " + suma);
           

        }
    }
}
