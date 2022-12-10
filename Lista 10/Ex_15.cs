static void Main(string[] args)
        {

            //Modifique o programa anterior para não aceitar a entrada do número zero, e requisitar
            //a digitação de outro número neste caso.


            int[] tam = new int[5];
            int[] par = new int[tam.Length];
            int[] impar = new int[tam.Length];

            for (int i = 0; i < tam.Length; i++)
            {
                Console.WriteLine("Digite os números: ");
                int num = int.Parse(Console.ReadLine());

                tam[i] = num;
                while (tam[i] == 0)
                {
                    Console.Write("Erro! Digite um número maior.");
                    Console.WriteLine("Digite um número maior que zero: ");
                    num = int.Parse(Console.ReadLine());
                    tam[i] = num;
                    break;

                }
            }


            int somaPar = 0;

            for (int i = 0; i < tam.Length; i++)
            {
                if (tam[i] % 2 == 0)
                {
                    par[i]++;
                    somaPar += par[i];

                }

            }
            Console.WriteLine("\nPares: " + somaPar);

            int somaImpar = 0;
            for (int i = 0; i < tam.Length; i++)
            {
                if (tam[i] % 2 != 0)
                {
                    impar[i]++;
                    somaImpar += impar[i];


                }
            }
            Console.WriteLine("\nÍmpar: " + somaImpar);

            
        }
