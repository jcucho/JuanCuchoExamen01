// See https://aka.ms/new-console-template for more information
int opcion = 0;
do
{
    try
    {
        Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
        Console.WriteLine("===========================");

        Console.WriteLine("\n");//Salto de Línea
        Console.WriteLine("1.Determinar si un número ingresado por el usuario es positivo, negativo o cero");
        Console.WriteLine("2.Imprimir un mensaje según el día de la semana ingresado por el usuario");
        Console.WriteLine("3.Calcular la suma de los primeros 100 números naturales");
        Console.WriteLine("4.Imprimir todos los números desde 1 hasta el número ingresado por el usuario");
        Console.WriteLine("5.Calcular el área de un círculo utilizando el radio ingresado por el usuario");
        Console.WriteLine("6.Mostrar los elementos de un arreglo unidimensional predefinido");
        Console.WriteLine("7.Mostrar nombres de personas almacenados en una lista predefinida");
        Console.WriteLine("8.Salir");
        Console.WriteLine("\n");//Salto de Línea
        opcion = Convert.ToInt32(Console.ReadLine());
        int numeroIngresado;
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese numero:");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                string mensaje = determinarNumeroIngresado(numeroIngresado);
                Console.WriteLine(mensaje);
                break;

            case 2:
                Console.WriteLine("Ingrese dia de la semana:");
                string dia = Console.ReadLine();
                mensajePorDiaDeSemana(dia);
                break;
            case 3:
                Console.WriteLine("La suma de los 100 primeros numeros naturales es :" + calcularSuma100PrimerosNumerosNaturales());
                break;
            case 4:
                Console.WriteLine("Ingrese numero:");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("============");
                imprimirNumerosDesde1HastaIngresado(numeroIngresado);
                break;
            case 5:
                double area = 0;
                Console.WriteLine("Ingrese radio del circulo:");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                area = calcularAreaCirculo(numeroIngresado);
                Console.WriteLine("El área del circulo de radio " + numeroIngresado + " es: " + area);
                break;
            case 6:
                int[] datos = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("arreglo datos = { 1, 2, 3, 4, 5, 6 }");
                mostrarContenidoArregloPredefinido(datos);
                break;
            case 7:
                List<string> nombres = new List<string>() { "Juan", "Marla", "Yamile", "Mateo", "Francisca", "Eduardo" };
                Console.WriteLine("\n");
                Console.WriteLine("lista nombres = { \"Juan\", \"Marla\", \"Yamile\", \"Mateo\", \"Francisca\", \"Eduardo\" }");
                mostrarContenidoListaPredefinida(nombres);
                break;
            default:
                Console.WriteLine("BYE");
                break;
        }
    }
    catch (Exception e)
    {
        Console.Write("Debe ingresar obligatoriamente un número entero.");
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");//Salto de Línea
} while (opcion != 8);



string determinarNumeroIngresado(int numeroIngresado)
{
    string mensaje = "";
    if (numeroIngresado < 0)
        mensaje = "El numero ingresado es negativo";
    else if (numeroIngresado == 0)
        mensaje = "El numero ingresado es cero";
    else
        mensaje = "El numero ingresado es positivo";
    return mensaje;

}

int calcularSuma100PrimerosNumerosNaturales()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
        suma += i;
    return suma;
   
}

void imprimirNumerosDesde1HastaIngresado(int numeroIngresado)
{
    for (int i = 1; i <= numeroIngresado; i++)
        Console.WriteLine(i);
    Console.WriteLine("\n");//Salto de Línea
}

double calcularAreaCirculo(int radio)
{
    return (Math.Round(Math.PI * Math.Pow(radio, 2),2));
}

void mensajePorDiaDeSemana(string dia)
{
    string mensaje="";
    switch (dia.ToUpper())
    {
        case "LUNES":
            mensaje = "primer";
            break;
        case "MARTES":
            mensaje = "segundo";
            break;
        case  "MIERCOLES":
            mensaje = "tercer";
            break;
        case "JUEVES":
            mensaje = "cuarto";
            break;
        case "VIERNES":
            mensaje = "quinto";
            break;
        case "SABADO":
            mensaje = "sexto";
            break;
        case "DOMINGO":
            mensaje = "ultimo";
            break;
        default:
            mensaje = "";
            break;
    }
    if(mensaje != "")
        Console.WriteLine(dia + " es el " + mensaje + " dia de la semana");
    else
        Console.WriteLine(dia + " no existe");
}

void mostrarContenidoArregloPredefinido(int[] datos)
{
    for (int i = 0; i < datos.Length; i++)
        Console.WriteLine("El contenido del arreglo datos[" + i + "] es : " + datos[i]);
}

void mostrarContenidoListaPredefinida(List<string> nombres)
{
    int i= 0;
    foreach (var nombre in nombres)
    {
        Console.WriteLine("El contenido de la lista nombres[" + i + "] es : " + nombre);
        i++;
    }
}