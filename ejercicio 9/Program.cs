using System;
class programm
{

    static void Main(string[] args)
    {
        /*Se desea realizar un programa en C#. Que calcule el mayor 
         * de 3 números enteros ingresados por teclado.*/

        int n1, n2, n3;


        Console.WriteLine("digite su primer numero :");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite su segundo numero :");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite su tercer numero :");
        n3 = int.Parse(Console.ReadLine());

        int mayor = n1;

        if (n2 > mayor)
        {
           mayor=n2;
        }
        if (n3 > mayor)
        {
            mayor=n3;
        }
        Console.WriteLine("El mayor es :" + mayor);
    }



}
