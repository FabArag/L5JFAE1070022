internal class Program
{
    private static void Main(string[] args)
    {
        int Dia = 0;

        // Mensaje en pantalla//
        Console.WriteLine("EJERCICIO 02");
        Console.WriteLine("Ingrese un el numero de dia");


        //siguiente es recicibir y almacenar//

        Dia = Convert.ToInt32(Console.ReadLine());

        if (Dia == 1)
        {
            Console.WriteLine("El dia es Lunes");
        }
        else if (Dia == 2)
        {
            Console.WriteLine("El dia es Martes");
        }
        if (Dia == 3)
        {
            Console.WriteLine("El dia es Miercoles");
        }
        if (Dia == 4)
        {
            Console.WriteLine("El dia es Jueves");
        }
        if (Dia == 5)
        {
            Console.WriteLine("El dia es Viernes");
        }
        if (Dia == 6)
        {
            Console.WriteLine("El dia es Sabado");
        }
        if (Dia == 7)
        {
            Console.WriteLine("El dia es Domingo");
        }
        if (Dia > 7)
        {
            Console.WriteLine("Error: Debe ingresar un numero entre 1 y 7");
        }
        if (Dia <= 0)
        {
            Console.WriteLine("Error: Debe ingresar un numero entre 1 y 7");
        }
    }
}