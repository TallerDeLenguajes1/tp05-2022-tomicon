// See https://aka.ms/new-console-template for more information
int operacion= 1;
while (operacion != 5)
{
    Console.WriteLine("Que operacion desea reaizar? (1=suma, 2=resta, 3=multiplicacion, 4=division, 5=salir)\n");
    operacion= Convert.ToInt32(Console.ReadLine());
    double operando1, operando2, resultado;
    switch (operacion)
    {
        case 1:
            Console.WriteLine("Que numeros desea sumar?\n");
            operando1= Convert.ToDouble(Console.ReadLine());
            operando2= Convert.ToDouble(Console.ReadLine());
            resultado= operando1 + operando2;
            Console.WriteLine("El resultado es: " + resultado);
            break;
        case 2:
            Console.WriteLine("Que numeros desea restar?\n");
            operando1= Convert.ToDouble(Console.ReadLine());
            operando2= Convert.ToDouble(Console.ReadLine());
            resultado= operando1 - operando2;
            Console.WriteLine("El resultado es: " + resultado);
            break;
        case 3:
            Console.WriteLine("Que numeros desea multiplicar?\n");
            operando1= Convert.ToDouble(Console.ReadLine());
            operando2= Convert.ToDouble(Console.ReadLine());
            resultado= operando1 * operando2;
            Console.WriteLine("El resultado es: " + resultado);
            break;
        case 4:
            Console.WriteLine("Que numeros desea dividir?\n");
            operando1= Convert.ToDouble(Console.ReadLine());
            operando2= Convert.ToDouble(Console.ReadLine());
            resultado= operando1/operando2;
            Console.WriteLine("El resultado es: " + resultado);
            break;
        case 5:
            Console.WriteLine("Fin de la calculadora\n");
            break;
        default:
            Console.WriteLine("La operacion ingresada no es valida\n");
            break;
    }
}
