using System;

namespace AgendaDeContatos {
    class Program {
        public static void Main(string[] args) {
            Lista lista = new Lista();
            /*lista.inserir(69);
            lista.inserir(169);
            lista.inserir(269);
            lista.inserir(369);
            lista.inserir(469);

            while (!lista.isEmpty()) {
                int e = lista.retirar();
                Console.WriteLine($"Retirei o elemento {e}");
            */
            int switchCase = direciona;

            switch (switchCase){
              case 1:
                    Inserir(contato dado);
                        break;
              case 2:
                    Alterar(contato dado); //Altera contato com consulta
                        break;
              case 3:
                    Retirar(); //Exclui contato com consulta
                        break;
              case 4:
                    Listar(); //Exibe os contatos na tela. Antes pergunta o critério, alfabética ou nascimento
                        break;
              case 5:
                    Sair(); //fecha o programa, é um this.close, algo assim
                        break;
            }

        }
    }
}
