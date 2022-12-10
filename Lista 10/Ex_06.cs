static void Main(string[] args)
        {

            //Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número
            //1, 3 e 4, nesta ordem. O vetor terá no máximo 100 posições.Sair do programa quando for digitado
            //- 1.

            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int tam = 10;


            int[] arr = new int[tam];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] == 1){
                    cont1 += 1;
                }
                if (arr[i] == 3){
                    cont2 += 1;
                }
                if (arr[i] == 4)
                {
                    cont3 += 1;
                }
                if (arr[i] == -1)
                {
                    Console.WriteLine("Erro! Digite um número positivo.");
                    break;
                }
            }
            Console.WriteLine($"O número 1 foi digitado {cont1} vezes.\nO número 3 foi digitado {cont2} vezes\nO número 4 foi digitado {cont3} vezes.");
        }
