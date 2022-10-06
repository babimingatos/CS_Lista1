 static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string texto = Console.ReadLine();           
            Console.WriteLine(qtdEspacos(texto).ToString() + " Espaços");
            Console.ReadLine();
        }

        static int qtdEspacos(string texto)
        {
            int qtd = 0;
            foreach (char letra in texto)
            {
                if (char.IsWhiteSpace(letra))
                {
                    qtd++;
                }
            }
            return qtd;
        }
