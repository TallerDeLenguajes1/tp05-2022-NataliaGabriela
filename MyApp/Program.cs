// See https://aka.ms/new-console-template for more information
int primerNumero, segundoNumero;
double numeroIngresado;

Console.WriteLine("Ingrese el numero para calcular");
numeroIngresado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Valor Absoluto:" + Math.Abs(numeroIngresado));
Console.WriteLine("Cuadrado del numero:" + Math.Pow(numeroIngresado,2));
if(numeroIngresado>0){
        Console.WriteLine("Raiz Cuadrada:" + Math.Sqrt(numeroIngresado));
    }else{
        Console.WriteLine("Ingrese un numero mayor que cero");
    }

Console.WriteLine("Seno:" + Math.Sin(numeroIngresado));
Console.WriteLine("Coseno:" + Math.Cos(numeroIngresado));
Console.WriteLine("Parte entera:" + Math.Truncate(numeroIngresado));

Console.WriteLine("Ingrese el primer numero para calcular");
primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero para calcular");
segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El mximo es : " + Math.Max(primerNumero,segundoNumero));
Console.WriteLine("El minimmo es : " + Math.Min(primerNumero,segundoNumero));
