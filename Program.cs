using System;

namespace Walking {
    class Program {
        static void Main(string[] args) {
            Player p = new Player("P", "Q");
            Cenario c = new Cenario("_", 60);
            ConsoleKey tecla;

            c.Imprimir(p);

            do {
                tecla = Console.ReadKey().Key;

                switch (tecla) {
                    case ConsoleKey.LeftArrow:
                        //ANDAR PARA ESQUERDA
                        p.anda(false, c.Tamanho);
                        c.Imprimir(p);
                        break;

                    case ConsoleKey.RightArrow:
                        //ANDAR PARA DIREITA
                        p.anda(true, c.Tamanho);
                        c.Imprimir(p);
                        break;

                    case ConsoleKey.UpArrow:
                        //PULAR
                        p.Pulando = true;
                        c.Imprimir(p);
                        p.pula();
                        p.Pulando = false;
                        c.Imprimir(p);
                        break;

                    default:
                        c.Imprimir(p);
                        break;

                }

            } while (tecla != ConsoleKey.Escape);
        }
    }
}
