/*  Teste do algoritmo
    Posição Inicial: +
    X = 1
    Y = 2
    D = N     Direções: N(Norte)- S(Sul)- L(Leste)- O(Oeste)
    Comando = EMEMEMEMM 
*/
int posicaoX = 1;
int posicaoY = 2;
char orientação = 'N';

string comandoCompleto = "EMEMEMEMM";

Console.WriteLine($"Posição inicial: X={posicaoX} Y={posicaoY} O={orientação}");

char[] instrucoes = comandoCompleto.ToCharArray();

for (int contador = 0; contador < instrucoes.Length; contador++)
{
    char instrucao = instrucoes[contador];
}