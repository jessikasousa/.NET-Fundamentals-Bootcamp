/*O banco que você trabalha sempre tem problemas para organizar as filas de atendimento dos clientes.

Após uma reunião com a gerência ficou decidido que os clientes ao chegar na agência receberão uma senha numérica em seu aparelho de celular via sms e que a ordem da fila será dada não pela ordem de chegada, mas sim pelo número recebido via sms. A ordem de atendimento será decrescente: aqueles que receberam número maior deverão ser atendidos primeiro. 

Então, dada a ordem de chegada dos clientes reordene a fila de acordo com o número recebido via sms, e diga quantos clientes não precisaram trocar de lugar nessa reordenação.*/

using System;
using System.Collections.Generic;

    public class Desafio {
        public static void Main() {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++) {
                if (i > 1000) return;

                int pessoas = int.Parse(Console.ReadLine());
                
                List<int> lista = new List<int>();
                string[] line = Console.ReadLine().Split(" ");
                
                foreach (string item in line) {
                    if (lista.Count > 1000) return;
                    lista.Add(int.Parse(item));
                }
                lista.Sort((a, b) => b.CompareTo(a));

                int quantidade = pessoas;
                for (int x = 0; x < lista.Count; x++) {
                    if (int.Parse(line[x]) != lista[x]) {
                        quantidade--;
                    }
                }
                Console.WriteLine(quantidade);
            }
        }
    }
