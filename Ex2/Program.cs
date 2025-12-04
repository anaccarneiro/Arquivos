using System;
using System.IO;
using System.Text;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*02. Escreva um método que imprima o maior peso, o menor peso e a média de peso dos animais presentes no arquivo.*/
            MaiorPeso();
        }
        static void MaiorPeso()
        {
            try
            {
                StreamReader arq = new StreamReader("C:\\Users\\igorc\\source\\repos\\Lista 10 - ATP\\arquivo-01.txt");

                string[] linhas = new string[10];
                int quant = 0;
                string linha;

                linha = arq.ReadLine();

                while (linha != null)
                {
                    linhas[quant] = linha;
                    quant++;
                    linha = arq.ReadLine();
                }

                arq.Close();

                int maior = int.MinValue;
                int menor = int.MaxValue;
                int peso, soma = 0;
                double media = 0;

                for (int i = 0; i < quant; i++)
                {
                    string[] partes = linhas[i].Split(';');
                    peso = int.Parse(partes[4]);

                    if (peso > maior)
                    {
                        maior = peso;
                    }
                    if (peso < menor)
                    {
                        menor = peso;
                    }

                    soma += peso;
                }

                media = (double)soma / quant;

                Console.WriteLine($"Menor peso: {menor}\n" +
                    $"Maior peso: {maior}\n" +
                    $"Média dos pesos: {media}");
            }

            catch (Exception e)
            {
                Console.WriteLine("Erro" + e.Message);
            }
        }
    }
}
