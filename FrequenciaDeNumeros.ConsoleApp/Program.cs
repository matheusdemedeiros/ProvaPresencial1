using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de valores: ");
            int qtdValores = int.Parse(Console.ReadLine());
            int valorAtual = -1;
            int[] valores = new int[qtdValores];
            string[] valoresComQuantidade = new string[qtdValores];

            //for (int j = 0; j < valoresComQuantidade.Length; j++)
            //{
            //    valoresComQuantidade[j] = "p|0";
            //}

            for (int i = 1; i <= qtdValores; i++)
            {
                Console.Write("Informe o {0}º valor : ", i);
                valorAtual = int.Parse(Console.ReadLine());
                valores[i - 1] = valorAtual;
            }

            Array.Sort(valores);
           
            bool continuar = true;
            while (continuar)
            {
                int contadorDeNumero = 1;
                for (int j = 0; j < valores.Length; j++)
                {
                    if (j != valores.Length)
                    {
                        for (int i = j; i < valores.Length; i++)
                        {
                            valorAtual = valores[i];
                            if (valores[i] == valores[j])
                            {
                                contadorDeNumero++;
                            }
                            else
                            {
                                break;
                            }

                        }
                        Console.WriteLine("{0} aparece ({1}) vez(es)", valorAtual, contadorDeNumero);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
