using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*03. Escreva um método que imprima o nome popular de todos os animais cuja idade máxima em cativeiro esteja entre 10 e 16
             anos.*/

            NomePopular();
        }
        static void NomePopular()
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

                int idadeMaxima = 0;

                for (int i = 0; i < quant; i++)
                {
                    string[] partes = linhas[i].Split(';');
                    idadeMaxima = int.Parse(partes[4]);

                    if (idadeMaxima >= 10 && idadeMaxima <= 16)
                    {
                        Console.WriteLine(partes[0]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro" + e.Message);
            }
        }
    }
}
