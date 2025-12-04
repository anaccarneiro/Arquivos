using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NomeFelinos();
        }
        static void NomeFelinos()
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

                for (int i = 0; i < quant; i++)
                {
                    string[] partes = linhas[i].Split(';');
                    Console.WriteLine(partes[1]); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao ler arquivo: " + e.Message);
            }
        }
    }
}
