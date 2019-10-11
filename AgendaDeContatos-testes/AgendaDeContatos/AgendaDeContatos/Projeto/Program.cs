using System;

namespace AgendaDeContatos {
    class Program {
        public static void Main(string[] args) {
            Lista lista = new Lista();
            Console.WriteLine("Qual o nome do contato?");
            string inputNome = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento? AAAA/MM/DD");
            string inputNascimento = Console.ReadLine();
            Console.WriteLine("Qual o endereço?");
            string inputEndereco = Console.ReadLine();
            Console.WriteLine("Qual o CPF?");
            string inputCpf = Console.ReadLine();
            Console.WriteLine("Qual o telefone?");
            string inputTelefone = Console.ReadLine();
            Console.WriteLine("Qual o E-mail?");
            string inputEMail = Console.ReadLine();
            lista.inserir(inputNome, inputNascimento, inputEndereco, inputCpf, inputTelefone, inputEMail);
            /*lista.inserir(169);
            lista.inserir(269);
            lista.inserir(369);
            lista.inserir(469);

            while (!lista.isEmpty()) {
                int e = lista.retirar();
                Console.WriteLine($"Retirei o elemento {e}");
            */
            /* int switchCase = direciona;

             switch (switchCase){
               case 1:
                     Inserir(Contato dado);
                         break;
               case 2:
                     Alterar(Contato dado); //Altera contato com consulta
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
             }*/

            lista.listar();

        }
    }
}
