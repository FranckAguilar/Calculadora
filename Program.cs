Console.WriteLine("Numero 1");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Numero 2");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Selecciona: +, -, *, /");
string opcion = Console.ReadLine();

double resultado = 0;

// Escribir codigo aqui
switch (opcion)
{
    case "+":
        resultado = num1 + num2;
        break;
    case "-":
        resultado = num1 - num2;
        break;
    default:
        Console.WriteLine("Error");
        return;
}

Console.WriteLine("Resultado: " + resultado);