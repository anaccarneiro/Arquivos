using System;
using System.IO;
using System.Text;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*04. Escreva um programa que exiba, por linha do “arquivo-02.txt”, o nome de todos os felinos existentes no
            “arquivo-01.txt” cujo peso máximo esteja dentro dos limites do intervalo.
            Obs. 1: Os intervalos são fechados (utilizar <= e/ou >= nas cláusulas).
            Obs. 2: O programa deve ser genérico – intervalos não devem ser programados manualmente.*/

            try
            {
                StreamReader arq1 = new StreamReader("C:\\Users\\igorc\\source\\repos\\Lista 10 - ATP\\arquivo-01.txt");
                StreamReader arq2 = new StreamReader("C:\\Users\\igorc\\source\\repos\\Lista 10 - ATP\\arquivo-02.txt");

                string[] linhasArq1 = new string[10];
                string[] linhasArq2 = new string[6];

                int quant1 = 0, quant2 = 0;

                string linhaArq1, linhaArq2;

                linhaArq1 = arq1.ReadLine();
                linhaArq2 = arq2.ReadLine();

                while (linhaArq1 != null)
                {
                    linhasArq1[quant1] = linhaArq1;
                    quant1++;
                    linhaArq1 = arq1.ReadLine();
                }

                while (linhaArq2 != null)
                {
                    linhasArq2[quant2] = linhaArq2;
                    quant2++;
                    linhaArq2 = arq2.ReadLine();
                }
                
                arq1.Close();
                arq2.Close();

                for (int i = 0; i < quant2; i++)
                {
                    for (int j = 0; j < quant1; j++)
                    {
                        string[] partesArq1 = linhasArq1[j].Split(';');
                        int peso = int.Parse(partesArq1[3]);

                        string[] partesArq2 = linhasArq2[i].Split(';');
                        int pesoMin = int.Parse(partesArq2[0]);
                        int pesoMax = int.Parse(partesArq2[1]);

                        if (peso >= pesoMin && peso <= pesoMax)
                        {
                            Console.Write(partesArq1[0]+", ");
                        }
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro" + e.Message);
            }
        }
    }
}
