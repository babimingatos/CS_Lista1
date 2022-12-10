static void Main(string[] args)
        {

            //Escreva um algoritmo que solicite ao usuário a entrada de 5 nomes, e que exiba a lista
            //desses nomes na tela.Após exibir essa lista, o programa deve mostrar também os nomes na ordem inversa em
            //que o usuário os digitou, um por linha

            string[] nomes = new string[4];
            string[] nomesi = new string[4];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
            }
            for(int i = 0; i < nomes.Length; i++)
            {
                nomesi[i] = nomes[(nomes.Length - i) - 1];
              
                nomesi[i].ToList().ForEach(Console.WriteLine);
            }
            
            Console.WriteLine("Os nomes digitados foram: ");
            nomes.ToList().ForEach(Console.WriteLine);
          
        }
