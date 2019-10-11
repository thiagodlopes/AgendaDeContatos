using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos {
    public class Lista {
        private No inicio;

        //criando lista vazia
        public Lista() {
            this.inicio = null;
        }

        public void inserir(Contato dado) { //Ver como ficacom os vários tipos de dado
            //precisa criar outro No
            No novo = new No();
            novo.setDado(dado); //Insere o dado no No
            novo.setProximo(null);      //Dps dela n vem ngm

            if (inicio == null) { //É o 1º No?
                inicio = novo;
            }
            else {                //Não é o 1º
                No aux;
                aux = inicio;
                while (aux.getProximo() != null) {
                    aux = aux.getProximo();
                }
                aux.setProximo(novo);
            }
        }

        public void listar() { //Precisa perguntar o critério e organizar baseado nele
            if (inicio == null) {
                Console.WriteLine("Lista Vazia");
            }
            else {
                No aux = inicio;
                while (aux != null) {
                    Console.WriteLine($"Dado visto: {aux.getDado()}");
                    aux = aux.getProximo();
                }
            }
        }

        public Contato retirar() { //Precisa consultar
            //Considera que a lista sempre tem dados
            //Alguém na aplicação precisa, antes de remover, testar se a lista está vazia
            No aux = inicio;
            Contato dado = aux.getDado();
            inicio = aux.getProximo();
            return dado;
        }

        public bool isEmpty() {
            return this.inicio == null;
        }
    }
}
