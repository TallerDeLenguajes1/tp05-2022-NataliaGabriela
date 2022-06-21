// See https://aka.ms/new-console-template for more information
int NumeroIngresado, NumeroInvertido;
NumeroInvertido= 0;

Console.WriteLine("Ingrese el numero a invertir, debe ser mayor que cero");
NumeroIngresado= Convert.ToInt32(Console.ReadLine());
if (NumeroIngresado > 0)
{
while (NumeroIngresado > 0)
{
    NumeroInvertido= NumeroInvertido * 10 + NumeroIngresado % 10;
    NumeroIngresado= NumeroIngresado/10;
}
  Console.WriteLine("El numero invertido es: " + NumeroInvertido);    
}
else
{
      Console.WriteLine("No se puede invertir porque es mayor que 0\n");
}