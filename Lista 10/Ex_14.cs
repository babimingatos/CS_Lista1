 static void Main(string[] args)
        {

            // Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
            // um somente para números pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela,
            // em sequência.Obs.: As posições que não receberem valores exibirão o número zero. Não se preocupe
            //com isso por enquanto.


            int[] tam = new int[5];
            int[] par = new int[tam.Length];
            int[] impar = new int[tam.Length];

            for (int i = 0; i < tam.Length; i++)
            {
                Console.WriteLine("Digite os números: ");
                int num = int.Parse(Console.ReadLine());
                tam[i] = num;
            }

            int somaImpar = 0;
            for (int i = 0; i < tam.Length;i++)
            {    
                if (tam[i] % 2 != 0)
                {
                    impar[i]++;
                    somaImpar += impar[i];


                }            
            }
            Console.WriteLine("Ímpar: "+somaImpar);
            
            int somaPar = 0;

            for (int i = 0; i < tam.Length;i++)
            {
                if (tam[i] % 2 == 0)
                {
                    par[i]++;
                    somaPar += par[i];

                }            
            }
            Console.WriteLine("\nPares: "+somaPar);
        }
