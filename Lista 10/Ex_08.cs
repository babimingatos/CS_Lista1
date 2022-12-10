static void Main(string[] args)
        {

            //Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a
            // quantidade de números pares e de múltiplos de 5
            int[] guarda = new int[5];
            int par = 0;
            int cinco = 0;
          
            for (int i = 0; i < guarda.Length; i++)
            {

                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());
                guarda[i] = num;

            }
            for (int i = 0; i < guarda.Length; i++)
            {
                if (guarda[i] % 5 == 0)
                {
                    cinco++;
                }if(guarda[i] % 2 == 0)
                {
                    par++;
                }
            }
            Console.WriteLine("Multiplos de cinco: " + cinco +
                "\nPares: " + par);
        }
