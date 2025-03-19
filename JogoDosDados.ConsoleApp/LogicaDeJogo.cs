namespace JogoDosDados.ConsoleApp;

static class LogicaDeJogo
{
    public static void JogadaEspecial(int posicao, string jogador)
    {
        if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

            posicao += 3;

            Console.WriteLine($"O {jogador} avançou para a posição: {posicao}!");
            Console.WriteLine("----------------------------------");

        }
        else if (posicao == 7 || posicao == 13 || posicao == 20 || posicao == 26)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

            posicao -= 2;

            Console.WriteLine($"O {jogador} recuou para a posição: {posicao}!");
            Console.WriteLine("----------------------------------");
        }

    }
    public static int SortearDado()
    {
        Random lancadoDeDado = new Random();
        int dadoLancado = lancadoDeDado.Next(1, 7);

        return dadoLancado;
    }

}
