/*O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.

O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.*/


using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProgramaParaValidacaoDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcaoUsuario = 1.00;

            do
            {
                List<double> notasValidas = new List<double> { };
                double somaDasNotas = 0, media;

                while (notasValidas.Count != 2)
                {
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (nota < 0.0 || nota > 10.0)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        notasValidas.Add(nota);
                    }
                }

                foreach (double nota in notasValidas)
                {
                    somaDasNotas += nota;
                }

                media = somaDasNotas / notasValidas.Count;
                Console.WriteLine("media = {0}", media.ToString("F2", CultureInfo.InvariantCulture));

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcaoUsuario = double.Parse(Console.ReadLine());
                } while ((opcaoUsuario != 1 && opcaoUsuario != 2) && opcaoUsuario != 2);

            } while (opcaoUsuario != 2.00);
        }
    }

    class ValidaNota
    {
        private bool nota;
    }
}