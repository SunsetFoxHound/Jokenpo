using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write(@"Vamos jogar jokempô.

Digite 1 para pedra, 2 para papel ou 3 para tesoura... ");
        int Jogador = Convert.ToInt32(Console.ReadLine());

        string OpcaoC, OpcaoJ;

        int Computador = RandomNumberGenerator.GetInt32(1, 3);

        if (Jogador < 1 || Jogador > 3)
        {
            Console.WriteLine("Digite apenas 1, 2 ou 3");
        }

        else
        {
            if (Computador != 1)
            {
                if (Computador == 2)
                {
                    OpcaoC = "Papel";
                }
                else
                {
                    OpcaoC = "Tesoura";
                }
            }
            else
            {
                OpcaoC = "Pedra";
            }
            if (Jogador == 1)
            {
                OpcaoJ = "Pedra";
            }
            else
            {
                if (Jogador == 2)
                {
                    OpcaoJ = "Papel";
                }
                else
                {
                    OpcaoJ = "Tesoura";
                }
            }
            if (Jogador == Computador)
            {
                Console.WriteLine($"É. Eu também escolhi {OpcaoC}. Empatamos. Vamos jogar outra vez até alguém vencer. Spoiler: Vou ser eu");
            }

            else
            {
                if (Computador == 1 && Jogador == 3 || Computador == 2 && Jogador == 1 || Computador == 3 && Jogador == 2)
                {
                    Console.WriteLine($"Há! Venci! {OpcaoC} ganha de {OpcaoJ}. Porque não tenta de novo? Talvez tenha mais sorte na próxima");
                }

                else
                {
                    Console.WriteLine($"Droga. Perdi. Escolhi {OpcaoC} e você {OpcaoJ}. Mas na próxima eu ganho");
                }
            }
        }
    }
}