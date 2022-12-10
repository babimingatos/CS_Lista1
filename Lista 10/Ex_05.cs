static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alunos: ");
            int qtdA = int.Parse(Console.ReadLine());

            int[] qtdAl = new int[qtdA];
            double media = 0;
            double mediaTotal;
            int mediaMais7 = 0;
            int mediaMenos5 = 0;

            for (int i = 0; i < qtdAl.Length; i++)
            {
               
                Console.WriteLine("Digite a nota do aluno: ");
                int notaw = int.Parse(Console.ReadLine());
               
                qtdAl[i] = notaw;
                if (notaw > 7)
                {
                    mediaMais7++;
                }
                else if (notaw < 5)
                {
                    mediaMenos5++;

                }
            }


            for (int i = 0; i < qtdAl.Length; i++)
            {
                media += qtdAl[i];
            }
            mediaTotal = media / qtdA;

            Console.WriteLine($"Maior que 7: {mediaMais7}\n" +
               $"Menor que 5: {mediaMenos5}\n" +
               $"Média da sala: {mediaTotal}"); 
              

        }
