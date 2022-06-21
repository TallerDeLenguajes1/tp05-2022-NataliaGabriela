// See https://aka.ms/new-console-template for more information
string cadenaDeTexto,segundaCadena,subCadena,cadenaConcatenada;
int longitudCadena;

Console.WriteLine("Ingrese una cadena de  texto");
cadenaDeTexto = Console.ReadLine()!;
longitudCadena = cadenaDeTexto.Length;
Console.WriteLine("longitud de la cadena" + longitudCadena);
Random numeroAleatorio = new Random();

Console.WriteLine("caracter aleatorio " + cadenaDeTexto[(numeroAleatorio.Next(longitudCadena))]);
Console.WriteLine("Ingrese una segunda cadena de  texto ");
segundaCadena = Console.ReadLine()!;
cadenaConcatenada = cadenaDeTexto + segundaCadena;
Console.WriteLine("cadena concatenada " + cadenaConcatenada);
subCadena = cadenaConcatenada.Substring(longitudCadena);
Console.WriteLine("subcadena: "  + subCadena);