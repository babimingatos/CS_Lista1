 static void Main(string[] args)
        {
            //Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e
            //calcular a média. Imprimir também o maior. A quantidade de números lidos será
            //definida pelo usuário

            Console.Write("Digite a quantidade de números: ");
            int num = int.Parse(Console.ReadLine());
            int[] tam = new int[num];

            for (int i = 0; i < tam.Length; i++)
            {
                Console.Write("Digite os números: ");
                tam[i] = int.Parse(Console.ReadLine());

            }

            int maior = tam[0];
           

            for (int i = 0; i < tam.Length; i++)
            {
                if (tam[i]> maior)
                {
                    maior = tam[i];
                 
                }
            }

            int soma = 0;

            for (int i = 0; i < tam.Length; i++)
            {
                soma += tam[i];
            }
            double media = soma / tam.Length;
            Console.WriteLine($"Média dos números: {media}." +
                $"\nO maior digitado foi: "+maior);


           

        }
