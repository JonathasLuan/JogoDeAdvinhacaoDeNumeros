namespace testecódigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAdivinhar = random.Next(1, 101);
            int tentativaAtual = 0;
            int maximoTentativas = 5;
            bool acertou = false;

            while (tentativaAtual < maximoTentativas)
            {
                Console.Write("Tentativa {0} de {1}. Digite um número entre 1 e 100: ", tentativaAtual + 1, maximoTentativas);
                string entrada = Console.ReadLine();

                int tentativa;

                if (int.TryParse(entrada, out tentativa))
                {
                    if (tentativa == numeroAdivinhar)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        acertou = true;
                        break;
                    }
                    else if (tentativa < numeroAdivinhar)
                    {
                        Console.WriteLine("O número que você digitou é menor do que o número a ser adivinhado. Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("O número que você digitou é maior do que o número a ser adivinhado. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número entre 1 e 100.");
                }

                tentativaAtual++;
            }

            if (!acertou)
            {
                Console.WriteLine("Você não conseguiu adivinhar o número em {0} tentativas. O número era {1}.", maximoTentativas, numeroAdivinhar);
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

    }
}