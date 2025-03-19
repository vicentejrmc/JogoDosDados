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
                int posicaoUsuario = 0;
                int posicaoComputador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    bool rodadaExtra = true;

                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("--------- Jogo dos Dados ---------");
                    Console.WriteLine("\n----------------------------------");

                    Console.WriteLine($"Posição Atual Usuario: {posicaoUsuario} de {limiteLinhaChegada}");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Posição Atual Computador: {posicaoComputador} de {limiteLinhaChegada}");

                    while (rodadaExtra)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.WriteLine("------- Rodada do Usuário --------");
                        Console.WriteLine("----------------------------------");

                        Console.Write("Pressione ENTER para lançar o dado...");
                        Console.ReadLine();

                        int dadoUsuario = SortearDado();

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O valor sorteado foi: {dadoUsuario}!");
                        Console.WriteLine("----------------------------------");

                        posicaoUsuario += dadoUsuario;

                        Console.WriteLine($"Você vai avançar para a posição: {posicaoUsuario} de {limiteLinhaChegada}!");
                        
                        JogadaEspecial(posicaoUsuario);

                        if (dadoUsuario != 6)
                            break;
                        else if (dadoUsuario == 6)
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("EVENTO ESECIAL: Acertando o n° 6 no dado você ganhou uma rodada extra.");
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
  // --------------------------------------------------------------------------------------------

                    rodadaExtra = true;
                    while (rodadaExtra)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.WriteLine("------ Rodada do Computador ------");
                        Console.WriteLine("----------------------------------");
                        Console.Write("Pressione ENTER para visualizar a rodada do computador...");
                        Console.ReadLine();

                        int dadoComputador = SortearDado();

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O valor sorteado foi: {dadoComputador}!");
                        Console.WriteLine("----------------------------------");

                        posicaoComputador += dadoComputador;

                        Console.WriteLine($"O Computador vai avançar para a Posição: {posicaoComputador} de {limiteLinhaChegada}!");

                        JogadaEspecial(posicaoComputador);

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
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("EVENTO ESECIAL: Acertando o n° 6 no dado o Computador ganhou uma rodada extra.");
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


        static int SortearDado()
        {
            Random lancadoDeDado = new Random();
            int dadoLancado = lancadoDeDado.Next(1, 7);

            return dadoLancado;
        }

        static void JogadaEspecial(int posicao)
        {
            if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                posicao += 3;

                Console.WriteLine($"Você avançou para a posição: {posicao}!");
                Console.WriteLine("----------------------------------");

            }
            else if (posicao == 7 || posicao == 13 || posicao == 20 || posicao == 26)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                posicao -= 2;

                Console.WriteLine($"Você recuou para a posição: {posicao}!");
                Console.WriteLine("----------------------------------");
            }

        }

    }
}