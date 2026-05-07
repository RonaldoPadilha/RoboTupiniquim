class Program
{
    static void Main()
    {
        string opcao;

        do
        {
            Console.Clear();
            // --- Cabeçalho ---
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|           ROBÔ TUPINIQUIM             |");
            Console.WriteLine("-----------------------------------------\n");

            // --- Entrada de dados do Usuário ---
            Console.Write("Digite a posição X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite a posição Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Digite a orientação (N, S, L, O): ");
            char orientacao = char.Parse(Console.ReadLine().ToUpper());

            Robo.Configurar(x, y, orientacao);

            Console.Write("Digite os comandos (ex: EMEMEMEMM): ");
            string comandos = Console.ReadLine().ToUpper();

            // --- Execução ---
            Console.WriteLine($"\nPosição inicial: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");

            Robo.Executar(comandos);

            Console.WriteLine($"Posição final: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");

            // --- Pergunta para repetir ---
            Console.WriteLine("\nDeseja digitar novas coordenadas? (S/N)");
            opcao = Console.ReadLine().ToUpper();

        } while (opcao == "S");
    }
}