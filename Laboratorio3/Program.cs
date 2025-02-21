int opcion;
do
{
    Console.Clear();
    Console.WriteLine("Menú de programas:");
    Console.WriteLine("1. Calculadora básica");
    Console.WriteLine("2. Validación de contraseña");
    Console.WriteLine("3. Números primos");
    Console.WriteLine("4. Suma de números pares");
    Console.WriteLine("5. Conversión de temperatura");
    Console.WriteLine("6. Contador de vocales");
    Console.WriteLine("7. Cálculo de factorial");
    Console.WriteLine("8. Juego de adivinanza");
    Console.WriteLine("9. Paso por referencia");
    Console.WriteLine("10. Tabla de multiplicar");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Entrada inválida. Presione Enter para continuar...");
        Console.ReadLine();
        continue;
    }

    switch (opcion)
    {
        case 1: Calculadora(); break;
        case 2: ValidarContraseña(); break;
        case 3: NumerosPrimos(); break;
        case 4: SumaNumerosPares(); break;
        case 5: ConversionTemperatura(); break;
        case 6: ContadorVocales(); break;
        case 7: CalculoFactorial(); break;
        case 8: JuegoAdivinanza(); break;
        case 9: PasoPorReferencia(); break;
        case 10: TablaMultiplicar(); break;
        case 0: Console.WriteLine("Saliendo..."); break;
        default: Console.WriteLine("Opción no válida."); break;
    }

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
} while (opcion != 0);
    

    static void Calculadora()
{
    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.Write("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.Write("Seleccione operación (+, -, *, /): ");
    char operacion = Console.ReadKey().KeyChar;
    Console.WriteLine();

    double resultado = operacion switch
    {
        '+' => num1 + num2,
        '-' => num1 - num2,
        '*' => num1 * num2,
        '/' => num2 != 0 ? num1 / num2 : double.NaN,
        _ => double.NaN
    };

    Console.WriteLine($"Resultado: {resultado}");
}

static void ValidarContraseña()
{
    string contraseña;
    do
    {
        Console.Write("Ingrese la contraseña: ");
        contraseña = Console.ReadLine();
    } while (contraseña != "1234");

    Console.WriteLine("Acceso concedido.");
}

static void NumerosPrimos()
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out int num))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    bool esPrimo = num > 1;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
    Console.WriteLine(esPrimo ? "Es primo." : "No es primo.");
}

static void SumaNumerosPares()
{
    int suma = 0, num;
    do
    {
        Console.Write("Ingrese un número (0 para salir): ");
        if (!int.TryParse(Console.ReadLine(), out num)) continue;
        if (num % 2 == 0) suma += num;
    } while (num != 0);
    Console.WriteLine("Suma de pares: " + suma);
}

static void ConversionTemperatura()
{
    Console.Write("Ingrese temperatura: ");
    if (!double.TryParse(Console.ReadLine(), out double temp)) return;
    Console.Write("Convertir a (C/F): ");
    char tipo = Console.ReadKey().KeyChar;
    Console.WriteLine();
    Console.WriteLine(tipo == 'C' ? $"{(temp - 32) * 5 / 9}°C" : $"{temp * 9 / 5 + 32}°F");
}

static void ContadorVocales()
{
    Console.Write("Ingrese una palabra: ");
    string frase = Console.ReadLine().ToLower();
    int contador = 0;
    foreach (char c in frase) if ("aeiou".Contains(c)) contador++;
    Console.WriteLine($"Número de vocales: {contador}");
}

static void CalculoFactorial()
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 0) return;
    long factorial = 1;
    for (int i = 2; i <= num; i++) factorial *= i;
    Console.WriteLine($"Factorial: {factorial}");
}

static void JuegoAdivinanza()
{
    Random rnd = new Random();
    int numero = rnd.Next(1, 101), intento;
    do
    {
        Console.Write("Adivine el número del 1 al 100: ");
        if (!int.TryParse(Console.ReadLine(), out intento)) continue;
        Console.WriteLine(intento > numero ? "Muy alto" : intento < numero ? "Muy bajo" : "Correcto");
    } while (intento != numero);
}

static void PasoPorReferencia()
{
    Console.Write("Ingrese el primer número: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    int b = int.Parse(Console.ReadLine());
    (a, b) = (b, a);
    Console.WriteLine($"Intercambiados: {a}, {b}");
}

static void TablaMultiplicar()
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out int num)) return;
    for (int i = 1; i <= 10; i++)
        Console.WriteLine($"{num} x {i} = {num * i}");
}


