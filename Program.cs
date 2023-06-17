using System.Security.Cryptography;

Console.Write(@"Vamos jogar jokempô. Eu 

digite 1 para pedra, 2 para papel ou 3 para tesoura... ");
int Escolha = Convert.ToInt32(Console.ReadLine());

int Computador = RandomNumberGenerator.GetInt32(1, 4);

if (Escolha < 1 || Escolha > 3)
{
    Console.WriteLine("Digite apenas 1, 2 ou 3");
}

else
{
    if (Escolha == Computador)
    {
        Console.WriteLine($"É. Eu também escolhi {Computador}. Empatamos. Vamos jogar de novo");
    }

    else
    {
        if (Computador == 1 && Escolha == 3 || Computador == 2 && Escolha == 1)
        {
            Console.WriteLine($"Há. Escolhi {Computador}. Ganhei! Porque não tenta de novo? Talvez tenha mais sorte na próxima");
        }   
    }
    ;
}