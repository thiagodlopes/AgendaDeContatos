using System;

namespace AgendaDeContatos {
    class Program {
        public static void Main(string[] args) {
            Lista lista = new Lista();
            lista.inserir(69);
            lista.inserir(169);
            lista.inserir(269);
            lista.inserir(369);
            lista.inserir(469);

            while (!lista.isEmpty()) {
                int e = lista.retirar();
                Console.WriteLine($"Retirei o elemento {e}");
            }
            }
            
        }
    }

