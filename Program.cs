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
    case "+": //operacion suma
        resultado = num1 + num2;
        break;
    case "-": //operacion resta
        resultado = num1 - num2;
        break;
    case "*": //operacion multiplicacion
        resultado = num1 * num2;
        break;
    case "/":
    if (num2 != 0)
    {
        resultado = num1 / num2;
    }
    else
    {
        Console.WriteLine("Error");
        return;
    }
    break;
    default:
        Console.WriteLine("Error");
        return;
}
//Resultado de la operacion
Console.WriteLine("Resultado: " + resultado);