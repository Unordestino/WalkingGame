using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking {
    class Cenario {
        public string Chao { get; set; }
        public int Tamanho { get; set; }

        public Cenario(string chao, int tamanho) {
            this.Chao = chao;
            this.Tamanho = tamanho;
        }

        public void Imprimir(Player p) {
            Console.Clear();
            Console.WriteLine();

            //IMPRIME A PRIMEIRA LINHA
            if (p.Pulando) {
                for (int i = 0; i < p.Posicao; i++) {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Aparencia);
            } else {
                Console.WriteLine();
            }

            for (int i = 0; i < p.Posicao; i++) {
                Console.Write(Chao);
            }

            if (p.Pulando) Console.Write(" ");
            else Console.Write(p.Aparencia);

            for (int i = 0; i < (Tamanho - p.Posicao); i++) {
                Console.Write(Chao);
            }
        }

    }
}
