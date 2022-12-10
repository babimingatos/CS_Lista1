static void Main(string[] args)
        {
            int[] qtd = new int[20];
            string[] nomeq = new string[20];

            for (int i = 0; i < qtd.Length; i++)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                qtd[i] = idade;
                nomeq[i] = nome;
            }
            for (int i = 0; i < qtd.Length; i++)
            {
                if (qtd[i] > 17 && qtd[i] < 21)
                {
                    Console.WriteLine("\nNome: " + nomeq[i] +
                                        "\nIdade: " +qtd[i]);
                }
            }
        }
