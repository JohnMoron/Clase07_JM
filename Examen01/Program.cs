
using System.Diagnostics.Tracing;
using System.Security.Cryptography;

int opcion = 0;
int numero = 0;

do
{
    MostrarMenu();
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un número:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DeterminarNumero(numero));
            Console.WriteLine("============================================================");
            break;
        case 2:
            Console.WriteLine("Ingrese un número de día (1 = Lunes, 7 = Domingo):");
            int dia = Convert.ToInt32(Console.ReadLine());
            ImprimirMensajeDia(dia);
            Console.WriteLine("============================================================");
            break;
        case 3:
            Console.WriteLine("La suma de los primeros 100 números naturales es: " + CalcularSuma100());
            Console.WriteLine("============================================================");
            break;
        case 4:
            Console.WriteLine("Ingrese un número:");
            int limite = Convert.ToInt32(Console.ReadLine());
            ImprimirNumerosHasta(limite);
            Console.WriteLine("============================================================");
            break;
        case 5:
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del círculo es: " + CalcularAreaCirculo(radio));
            Console.WriteLine("============================================================");
            break;
        case 6:
            Console.WriteLine("Ingrese la cantidad de elementos para formar un arreglo");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[cantidad];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = i + 1;
            }
            MostrarArreglo(arreglo);
            Console.WriteLine("============================================================");
            break;
        case 7:
            Console.WriteLine("Ingrese la cantidad de Nombres a ingresar");

            string nombre = "";
            List<string> nombres = new List<string>();

            int cantidadNombres = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidadNombres; i++)
            {
                    Console.WriteLine("Nombre " + i + ":");
                    nombre = Console.ReadLine();
                    nombres.Add(nombre);
            }
            MostrarNombres(nombres);
            Console.WriteLine("============================================================");
            break;
        case 8:
            Console.WriteLine("Salir");
            break;
        default:
            Console.WriteLine("Opción inválida, favor ingrese algún valor de la Lista.");
            Console.WriteLine("============================================================");
            break;
    }

} while (opcion != 8);


void MostrarMenu()
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Determinar si un número es positivo, negativo o cero.");
    Console.WriteLine("2. Imprimir un mensaje según el día de la semana.");
    Console.WriteLine("3. Calcular la suma de los primeros 100 números naturales.");
    Console.WriteLine("4. Imprimir números desde 1 hasta el número ingresado.");
    Console.WriteLine("5. Calcular el área de un círculo.");
    Console.WriteLine("6. Mostrar elementos de un arreglo unidimensional.");
    Console.WriteLine("7. Mostrar nombres almacenados en una lista.");
    Console.WriteLine("8. Salir.");
    Console.WriteLine("============================================================");
}

string DeterminarNumero(int numero)
{
    string respuesta01 = "";

    if (numero > 0)
        respuesta01 = "El número es positivo";
    else
        if (numero < 0)
        respuesta01 = "El número es negativo";
    else
        respuesta01 = "El número es cero";

    return respuesta01;
}

void ImprimirMensajeDia(int dia)
    {
    switch (dia)
    {
        case 1:
            Console.WriteLine("Es Lunes.");
            break;
        case 2:
            Console.WriteLine("Es Martes.");
            break;
        case 3:
            Console.WriteLine("Es Miércoles.");
            break;
        case 4:
            Console.WriteLine("Es Jueves.");
            break;
        case 5:
            Console.WriteLine("Es Viernes.");
            break;
        case 6:
            Console.WriteLine("Es Sábado.");
            break;
        case 7:
            Console.WriteLine("Es Domingo.");
            break;
        default:
            Console.WriteLine("Día no existe.");
            break;
    }
}

int CalcularSuma100()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma += i;
    }
    return suma;
}

void ImprimirNumerosHasta(int numero)
{
    for (int i = 1; i <= numero; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

double CalcularAreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}

void MostrarArreglo(int[] arreglo)
{
    Console.WriteLine("Elementos del arreglo:");
    foreach (int elemento in arreglo)
    {
        Console.WriteLine(elemento);
    }
}
void MostrarNombres(List<string> nombres )
{
    Console.WriteLine("La Lista de nombres son:");
    foreach (var item in nombres)
    {
        Console.WriteLine(item);
    }
}