static void Main(string[] args)
        {

            int[] numx = new int[1];
            int[] numy = new int[10];

            int maiorX = 0;
            int menorX = 0;
            int igualX = 0;

            Console.WriteLine("Digite 1 número maior que 0 e positivo: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < numy.Length; i++)
            {
                Console.WriteLine("Digite 10 números maiores que 0 e positivos: ");
                int y = int.Parse(Console.ReadLine());

                if (y > 0)
                {
                    numy[i] = y;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("PRECISA SER MAIOR QUE ZERO E POSITIVO");
                        y = int.Parse(Console.ReadLine());
                        numy[i] = y;
                    } while (y <= 0);
                }

                if (numy[i] > x)
                {
                    maiorX++;
                }else if (x > numy[i])
                {
                    menorX++;
                }else if (x == numy[i])
                {
                    igualX++;
                }
            }

            Console.WriteLine($"Maiores que {x}: {maiorX}\n" +
                $"Menor que {x}: {menorX}\n" +
                $"Iguais a  {x}: {igualX}");

        }
