static void Main(string[] args)
        {

            //            Durante uma corrida de automóveis com N voltas de duração foram anotados para um
            //             piloto, na ordem, os tempos registrados(em segundos) em cada volta.Fazer um
            //             programa para ler os tempos das N voltas, calcular e imprimir:
            //                  i.melhor tempo;
            //                  ii.a volta em que o melhor tempo ocorreu;
            //                  iii.tempo médio das N voltas;


            Console.Write("Digite a quantidade de voltas: ");
            int qtdvoltas = int.Parse(Console.ReadLine());

            int[] arr = new int[qtdvoltas];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Digite o tempo de cada volta em seg: ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int melhorVolta = arr[0];
            int volta = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < melhorVolta)
                {
                    melhorVolta = arr[i];
                    volta = i;
                }
            }
            Console.WriteLine($"O melhor tempo de volta foi em: {melhorVolta} seg \nA volta em que o melhor tempo ocorreu:  {volta + 1+ "º"}");

            int soma = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                soma += arr[i];
            }
            double media = soma / arr.Length;
            Console.WriteLine($"Média do tempo: {media}.");
        }
