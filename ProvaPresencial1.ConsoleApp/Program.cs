using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdComandos = -1;
            char posicao = 'N';
            char[] serieComandosArray;
            while (true)
            {
                Console.Write("Informe a quantidade de comandos do sargento: ");
                qtdComandos = int.Parse(Console.ReadLine());
                if (qtdComandos >= 1 && qtdComandos <= 1000)
                {
                    Console.Write("\nInforme os comandos: ");
                    string serieComandos = Console.ReadLine().ToUpper();
                    if (serieComandos.Length == qtdComandos)
                    {
                        serieComandosArray = serieComandos.ToCharArray();
                        for (int i = 0; i < serieComandosArray.Length; i++)
                        {
                            if (serieComandosArray[i] == 'D')
                            {
                                if (posicao == 'N')
                                {
                                    posicao = 'L';
                                }
                                else if (posicao == 'L')
                                {
                                    posicao = 'S';
                                }
                                else if (posicao == 'S')
                                {
                                    posicao = 'O';
                                }
                                else if (posicao == 'O')
                                {
                                    posicao = 'N';
                                }
                            }
                            else if (serieComandosArray[i] == 'E')
                            {
                                if (posicao == 'N')
                                {
                                    posicao = 'O';
                                }

                                else if (posicao == 'O')
                                {
                                    posicao = 'S';
                                }
                                else if (posicao == 'S')
                                {
                                    posicao = 'L';
                                }
                                else if (posicao == 'L')
                                {
                                    posicao = 'N';
                                }
                            }
                        }
                        Console.Write("Posição final: {0}\n", posicao);
                        posicao = 'N';
                    }
                    else
                    {
                        Console.WriteLine("A quantidade de comandos informados deve ser igual ao número informado anteriormente!\n");
                        continue;
                    }
                    continue;
                }
                else if (qtdComandos == 0)
                {
                    Console.WriteLine("Você não informou mais nenhum comando!!\nSistema Encerrado!!");
                    break;
                }
                else
                {
                    Console.WriteLine("A quantidade de comandos é inválida!");
                    break;
                }
            }
        }
    }
}
