 static void Main(string[] args)
        {

            //Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando - os
            //em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por
            //5 Exiba os valores dos dois vetores na tela, simultaneamente, em duas colunas (um em cada coluna), uma posição por linha.
           
            int[] qtd = new int[3];
            int[] qtdIn = new int[3];
            int []mult =new int [3];
            for(int i = 0; i < qtd.Length; i++)
            {
                Console.WriteLine("Digite os números: ");
                int nums = int.Parse(Console.ReadLine());
                qtd[i] = nums;
            }
            for (int i = 0; i < qtd.Length; i++)
            {
                mult[i]=qtd[i]*5; 
                Console.WriteLine(mult[i] +"|"); 
               
            }
            for (int i = 0; i < 1; i++)
            {
               qtd.ToList().ForEach(Console.WriteLine);
            }
        }
