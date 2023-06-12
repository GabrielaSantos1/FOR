// usa o System, que tem as principais classes usadas
using System;
//cria a classe Programa
class Programa
{
    //cria um principal para começar o programa
    static void Main()
    {
        //cria a variável inteira chamada 'num' e já declara seu valor inicial como 0
        int num = 0;

        //fala para o user:
        Console.WriteLine("Digite um número inteiro positivo: ");
        //guarda a resposta do usuário como valor da variável 'num'
        num = int.Parse(Console.ReadLine());

        //fala para o user texto + o valor da variável 'num' + texto
        Console.WriteLine("Os primeiros " + num + " números pares são:");

        //para: cria uma variável inteira chamada 'i' e já declara seu valor inicial como 2; coloca que 'i' é menor ou igual à variável 'num' multiplicado por 2; e que 'i' é igual à i + 2 
        for (int i = 2; i <= num * 2; i += 2)
        {
            // fala para o user o valor atual da variável 'i' + um espaço
            Console.WriteLine( i + " ");
            //criando assim o loop de falar os números pares até o valor chegar na quantidade da variável 'num'
        }

    }

}
