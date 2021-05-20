using System;

namespace dio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Entradas = 3;

            for (int i = 1; i <= Entradas; i++)
            {

                int QtdGrupo = int.Parse(Console.ReadLine()); //exemplo de entrada: 10

                if (QtdGrupo >= 1 && QtdGrupo <= 500)
                {
                    string[] Tartarugas = Console.ReadLine().Split(" ");// exemplo de entrada 10 20 18 21 2 1 8 9 6 4
                    int MelhorTartaruga = 1;

                    foreach (var item in Tartarugas)
                    {
                        int Velocidade = int.Parse(item);

                        if (Velocidade >= 20)
                        {
                            MelhorTartaruga = 3;
                        }
                        else if (Velocidade >= 10 && Velocidade < 20 && MelhorTartaruga != 3)
                        {
                            MelhorTartaruga = 2;
                        }
                        else if (Velocidade < 10 && MelhorTartaruga != 2)
                        {
                            MelhorTartaruga = 1;
                        }
                    }
                    System.Console.WriteLine(MelhorTartaruga);
                }
                else
                {
                    System.Console.WriteLine("Insira um valor entre 1 e 500.");
                }

            }
        }
    }
}
