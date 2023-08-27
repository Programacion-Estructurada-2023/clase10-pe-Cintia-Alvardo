using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)

        {
         
            //Ejercicio clase 10
            //PROGRAMA PARA MOSTRAR MES SEGÚN EL NÚMERO

            //Iniciamos con el menú
            Console.WriteLine("\n------INCIANDO CON EL PROGRAMA------\n");
            Console.WriteLine("Ingrese un número para mostrarle el mes: \n");
            
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
                {
                    case 1:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Enero");
                        Console.WriteLine("\n------FIN DEL PROGRAMA------\n");

                        break;
                    case 2:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Febrero");
                        Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
                        break;
                    case 3:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Marzo");
                         Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
                        break;
                    case 4:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Abril");
                        Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
                        break;
                    case 5:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Mayo");
                        Console.WriteLine("\n------FIN  DEL PROGRAMA------\n");
                        break;
                    case 6:
                        Console.WriteLine("\n Usted ingreso el " + num + " así que corresponde al mes de Junio");
                        Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
                        break;
                    default:
                        Console.WriteLine("\nNúmero de mes incorrecto\n");
                        break;
                }
        }
    }
}