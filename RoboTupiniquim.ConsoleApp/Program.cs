/*  Teste do algoritmo
    Posição Inicial: +
    X = 1
    Y = 2
    D = N     Direções: N(Norte)- S(Sul)- L(Leste)- O(Oeste)
    Comando = EMEMEMEMM 
*/
int posicaoX = 1;
int posicaoY = 2;
char orientacao = 'N';

string comandoCompleto = "EMEMEMEMM";

Console.WriteLine($"Posição inicial: {posicaoX} {posicaoY} {orientacao}");

char[] instrucoes = comandoCompleto.ToCharArray();

for (int contador = 0; contador < instrucoes.Length; contador++)
{
    char instrucao = instrucoes[contador];

    if (instrucao == 'E')//Esquerda
    {
        if (orientacao == 'N') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'N';
    }
    else if (instrucao == 'D')
    {
        if (orientacao == 'N') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'N';
    }
    else if (instrucao == 'M')
    {
        if (orientacao == 'N') posicaoY++;
        else if (orientacao == 'S') posicaoY--;
        else if (orientacao == 'O') posicaoX--;
        else if (orientacao == 'L') posicaoX++;
    }
}
Console.WriteLine($"Posição final: {posicaoX} {posicaoY} {orientacao}");
Console.ReadLine();