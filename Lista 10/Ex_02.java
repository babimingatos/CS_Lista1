 static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de números que irá digitar: ");
            int tam = int.Parse(Console.ReadLine());

            int[] arr = new int[tam];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = arr.Length - 1; i>=0 ; i--)
        
            {
                Console.Write("\n"+arr[i]+" \n");
            }
        }
