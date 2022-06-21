// See https://aka.ms/new-console-template for more information

int primerNumero, segundoNumero,opcionACalcular, flag=1;
while(flag==1)
{
Console.WriteLine("Ingrese el primer numero para calcular");
primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero para calcular");
segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Seleccione la operacion a calcular: 1.Suma, 2.Resta, 3.Multiplicaion, 4.Division");
opcionACalcular = Convert.ToInt32(Console.ReadLine());

switch (opcionACalcular)
{
    case 1: Console.WriteLine("el resultado es: " + (primerNumero + segundoNumero));
    break;
    case 2: Console.WriteLine("el resultado es: " + (primerNumero - segundoNumero));
    break;
    case 3: Console.WriteLine("el resultado es: " + (primerNumero * segundoNumero));
    break;
    case 4:
            if(segundoNumero!=0){
                Console.WriteLine("el resultado es: " + (primerNumero / segundoNumero));
            }else{
                Console.WriteLine("el segundo debe ser distinto de cero");
            }
     
    break;
    default:
            Console.WriteLine("debe escoger una opcion");
    break;
}
Console.WriteLine("Desea realizar otra operacion?: 1.Si, 2.No");
flag = Convert.ToInt32(Console.ReadLine());
}


