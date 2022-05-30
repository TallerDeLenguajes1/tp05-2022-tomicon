// See https://aka.ms/new-console-template for more information
Console.WriteLine("||Invertir un número entero||\n");
int NumIngresado, NumInvertido;
NumInvertido= 0;

Console.WriteLine("Ingrese el numero que desea invertir (debe ser mayor que cero): ");
NumIngresado= Convert.ToInt32(Console.ReadLine());
if (NumIngresado <= 0)
{
    Console.WriteLine("No se realizara la inversion ya que el numero no es mayor que 0\n");
}
while (NumIngresado > 0)
{
    NumInvertido= NumInvertido * 10 + NumIngresado % 10;
    NumIngresado= NumIngresado/10;
}
if (NumInvertido > 0)
{
    Console.WriteLine("El numero invertido es: " + NumInvertido);    
}


