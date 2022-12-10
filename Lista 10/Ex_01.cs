 static void Main(string[] args)
        {

            //Escreva uma aplicação no qual o usuário deverá informar 10 números inteiro e maiores
            //que Zero em um vetor. Posteriormente exiba separadamente os números pares e os números
            //ímpares exibidos pelo usuário.

            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Digite 10 números maiores que 0: ");
                int n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    num[i] = n; //Salvar no vetor
                }
                else
                {
                    do
                    {
                        Console.Write("Valor Errado!");
                        Console.Write("Digite um número maior que zero.");
                        n = int.Parse(Console.ReadLine());
                        num[i] = n;
                    } while (n <= 0);
                }
            }

            Console.WriteLine("Números pares: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i] + " ");
                }
            }

            Console.WriteLine("Números ímpares: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine(num[i] + " ");
                }
            }

}
