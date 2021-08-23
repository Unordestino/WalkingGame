using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking {
    class Player {
        public int Posicao { get; set; }
        public string Aparencia { get; set; }
        public string FacingRight { get; set; }
        public string FacingLeft { get; set; }
        public Boolean Pulando { get; set; }

        public Player(String right, String left) {
            Posicao = 0;
            FacingRight = right;
            FacingLeft = left;
            Aparencia = FacingRight;
            Pulando = false;
        }

        public void pula() {
            Console.Beep(234, 100);
        }

        public void anda(Boolean direcao, int limite) {
            if (direcao) {
                if (Posicao < limite) {
                    Posicao++;
                    Aparencia = FacingRight;
                }
            } 
            else {
                if (Posicao > 0) {
                    Posicao--;
                    Aparencia = FacingLeft;
                }
            }
        }

    }
}
