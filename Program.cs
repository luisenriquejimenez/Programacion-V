using System;

namespace Fuciones
{
    class Program
    {
        static void Main(string[] args)
        {
             while(true)
        {
        Console.WriteLine("Ingrese area para calcular:");
        int TipoArea = Int32.Parse(Console.ReadLine());

        switch (TipoArea)
        {
            case 1: 
                AreaReactangulo();
                break;
            case 2: 
                AreaTriangulo();
                break;
        }

        Console.WriteLine("Desea Calcular otra arear ? Y/N");
        string respuesta = Console.ReadLine();

        if(respuesta != "Y")
        {
            break;
        }
    }
    }

    private static void AreaReactangulo()
{
    double area = 0, b = 0, h = 0;
    Console.WriteLine("Encontrar el Area de un Rectangulo.");
    Console.WriteLine("Ingrese la Base de rectangulo");
    b = Int32.Parse(Console.ReadLine()); 
    Console.WriteLine("Ingrese la altura del Rectangulo");
    h = Int32.Parse(Console.ReadLine());
    double Area = b * h;
    Console.WriteLine("El Area del Rectangulo: " + area);
}

private static void  AreaTriangulo()
{
    double Area = 0, b = 0, h = 0;
    Console.WriteLine("Encontra el Area de un Triangulo");
    Console.WriteLine("Ingrese la base del Triangulo");
    b = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la Altura del Triangulo");
    h = Int32.Parse(Console.ReadLine());
    Area = (b * h) / 2;
    Console.WriteLine("El Area del Triangulo" + Area); 
}

     
    }
}

