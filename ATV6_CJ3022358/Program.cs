int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{


    case 0:

        int a, temp;
        int soma = 0;

        for (a = 0; a < 8; a++)
        {

            Console.WriteLine("digite um valor ");
            temp = int.Parse(Console.ReadLine());
            if (temp < 0)
                break;
            soma = soma + temp;

            Console.WriteLine(" A media é {0}, soma", soma / 3);
        }
        break;



    case 1:
        Console.WriteLine("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
        break;



    case 2:
        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares de 1 até " + num + ":");

        for (int i = 2; i <= num; i += 2)
        {
            Console.WriteLine(i);
        }
        break;



    case 3:
        Console.WriteLine("Digite um número inteiro menor que 1000: ");
        int nu = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares de 1000 até " + nu + ":");

        for (int i = 1000; i <= nu; i += 2)
        {
            Console.WriteLine(i);
        }
        break;

    case 4:
        int somaPosi = 0;

        Console.WriteLine("Digite uma sequência de números inteiros (digite um número negativo para parar):");


        {
            Console.Write("Digite um número inteiro: ");
            int nume = int.Parse(Console.ReadLine());

            if (nume < 0)
            {
                break;
            }

            if (nume > 0)
            {
                somaPosi += nume;
                Console.WriteLine("Número positivo adicionado. Soma atual dos positivos: {somaPositivos}");
            }
        }

        Console.WriteLine("A soma dos números positivos é: {0}", somaPosi);
        break;


    case 5:

        Console.Write("Digite um número inteiro: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Os divisores do número {n1} são:");

        for (int d = 1; d <= n1; d++)
        {
            if (n1 % d == 0)
            {
                Console.WriteLine(d);

            }
        }
        break;

    case 6:

        int quanNum = 10;
        int[] numeros = new int[quanNum];
        int maior = int.MinValue;
        int menor = int.MaxValue;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < quanNum; i++)
        {
            Console.Write("Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine("O maior número digitado foi: {0} ", maior);
        Console.WriteLine("O menor número digitado foi: {0}", menor);
        break;

    case 7:

        int somaPar = 0;
        int somaImp = 0;

        Console.WriteLine("Digite uma sequência de números. Digite 0 para encerrar.");

        {
            Console.Write("Digite um número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                break;
            }

            if (n2 % 2 == 0)
            {
                somaPar += n2;
            }
            else
            {
                somaImp += n2;
            }
        }

        Console.WriteLine("A soma dos números pares é: {0}", somaPar);
        Console.WriteLine("A soma dos números ímpares é: {0}", somaImp);
        break;


}
    
