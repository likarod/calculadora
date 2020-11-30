/*
Ejercicio simple para manejar los bucles do-while en C#
 
 - Esta calculadora le pide repetidamente al usuario que ingrese dos valores y luego muestra su suma, hasta que el usuario ingresa salir.
*/

do {
    Console.Write("x=");
    string str= Console.ReadLine();
    if( str == "exit")
        break;

    int x = Convert.ToInt32(str);

    Console.Write("y=");
    int y = Convert.ToInt32(Console.ReadLine());

    int sum = x+y;
    console.WriteLine("Result: {0}", sum);
} 
while (true);