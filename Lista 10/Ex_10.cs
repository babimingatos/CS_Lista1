static void Main(string[] args)
        {

            //Escreva um algoritmo que solicite ao usuário a entrada de 5 números, e que exiba o
            //somatório desses números na tela.Após exibir a soma, o programa deve mostrar também os números que o usuário
            //digitou, um por linha.

            int[] tam = new int[5];
            int cont = 0;
            int soma = 0;
            for (int i = 0; i < tam.Length; i++)
            {
                Console.WriteLine("Digite os números: ");
                cont++;
                int num = int.Parse(Console.ReadLine());
                tam[i] = num;
                
            }
            for (int i = 0; i < tam.Length; i++)
            {
                soma += tam[i];
            }
            Console.WriteLine("A soma dos números é: " + soma+
                                "\nOs números digitados foram: ");
            tam.ToList().ForEach(Console.WriteLine);
        }
