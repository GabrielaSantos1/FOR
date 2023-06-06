using System;
class Programa
{
    static void Main()
    {
        int num = 0;

        Console.WriteLine("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Os primeiros " + num + " números pares são:");

        for (int i = 2; i <= num * 2; i += 2)
        {
            Console.WriteLine( i + " ");
        }

    }

}