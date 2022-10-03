
using System.Threading.Channels;
internal class Program
{
    private static void Main(string[] args)
    {
        int numeroEntero = 0;

        // Mensaje en pantalla//
        Console.WriteLine("EJERCICIO 01");
        Console.WriteLine("Número entero ");


        //siguiente es recicibir y almacenar//

        numeroEntero = Convert.ToInt32(Console.ReadLine());

        if (numeroEntero >= 1)
        {
            Console.WriteLine("Su número es positivo");
        }
        else if (numeroEntero <= -1)
        {
            Console.WriteLine("Su número es negativo");
        }
        else if (numeroEntero == 0)
        {
            Console.WriteLine("El numero es 0");
        }
    }
}