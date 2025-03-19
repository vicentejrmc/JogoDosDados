using System;

namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        while (true)
        {
            int posicaoUsuario = 0;
            int posicaoComputador = 0;
            bool jogoEmAndamento = true;
            string usuario = "Usuário";
            string computador = "Computador";

            while (jogoEmAndamento)
            {
                bool rodadaExtra = true;

                Console.Clear();

                while (rodadaExtra)
                {
                    ExibirMenu(posicaoUsuario, posicaoComputador, limiteLinhaChegada, usuario);

                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    int dadoUsuario = LogicaDeJogo.SortearDado();

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {dadoUsuario}!");
                    Console.WriteLine("----------------------------------");

                    posicaoUsuario += dadoUsuario;

                    Console.WriteLine($"Você vai avançar para a posição: {posicaoUsuario} de {limiteLinhaChegada}!");
                    
                    LogicaDeJogo.JogadaEspecial(posicaoUsuario, usuario);

                    if (dadoUsuario != 6)
                        break;
                    else if (dadoUsuario == 6)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESECIAL: Acertando o n° 6 no dado você ganhou uma rodada extra.");
                        Console.WriteLine("Pressine ENTER para usar a rodada extra..");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (posicaoUsuario >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                        continue;
                    }
                }
                Console.WriteLine();

                Console.WriteLine("----------------------------------");
                Console.Write("Pressione ENTER para visualizar a rodada do computador...");
                Console.ReadLine();

                Console.Clear();
                
                rodadaExtra = true;
                while (rodadaExtra)
                {
                    ExibirMenu(posicaoUsuario, posicaoComputador, limiteLinhaChegada, computador);

                    int dadoComputador = LogicaDeJogo.SortearDado();

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {dadoComputador}!");
                    Console.WriteLine("----------------------------------");

                    posicaoComputador += dadoComputador;

                    Console.WriteLine($"O Computador vai avançar para a Posição: {posicaoComputador} de {limiteLinhaChegada}!");

                    LogicaDeJogo.JogadaEspecial(posicaoComputador, computador);

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("\n O Computador foi mais Rapido do que você!");
                        continue;
                    }

                    if (dadoComputador != 6)
                        break;
                    else if (dadoComputador == 6)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.WriteLine("EVENTO ESECIAL: Acertando o n° 6 no dado o Computador ganhou uma rodada extra.");
                        Console.WriteLine("Pressine ENTER ver a rodada extra do Computador.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }

                Console.ReadLine();
            }

            Console.WriteLine("----------------------------------");
            Console.Write("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static int ExibirMenu(int posicaoUsuario, int posicaoComputador, int limiteLinhaChegada, string jogador)
    {
        int posicao = 0;
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("--------- Jogo dos Dados ---------");
        Console.WriteLine("----------------------------------\n");

        Console.WriteLine($"Posição Atual Usuario: {posicaoUsuario} de {limiteLinhaChegada}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Posição Atual Computador: {posicaoComputador} de {limiteLinhaChegada}");

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine($"------ Rodada do {jogador} ------");
        Console.WriteLine("----------------------------------\n");

        return posicao;
    }

}