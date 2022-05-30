// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero para realizarle diversas operaciones");
double operando, comparado1, comparado2;
operando= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El valor absoluto del numero ingresado es: " + Math.Abs(operando));
if (operando < 0)
{
    Console.WriteLine("la raiz cuadrada de el numero ingresado no esta definida");
} else
{
    Console.WriteLine("La raiz cuadrada del numero ingresado es: " + Math.Sqrt(operando));   
}
Console.WriteLine("El seno del numero ingresado es: " + Math.Sin(operando));
Console.WriteLine("El coseno del numero ingresado es: " + Math.Cos(operando));
Console.WriteLine("La parte entera del numero ingresado es: " + Math.Truncate(operando));
Console.WriteLine("Ingrese dos numeros para ser comparados");
comparado1= Convert.ToDouble(Console.ReadLine());
comparado2= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El maximo entre los dos numeros ingresados es: " + Math.Max(comparado1, comparado2));
Console.WriteLine("El minimo entre los dos numeros ingresados es: " + Math.Min(comparado1, comparado2));



