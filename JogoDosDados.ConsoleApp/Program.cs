using System;

namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("----------------------------------");

                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    Random lancadoDeDado = new Random();

                    int dadoLancado = lancadoDeDado.Next(1, 7);

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {dadoLancado}!");
                    Console.WriteLine("----------------------------------");

                    posicaoJogador += dadoLancado;

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                    }
                    else
                        Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}!");

                    Console.WriteLine("----------------------------------");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }

        }
    }
}       