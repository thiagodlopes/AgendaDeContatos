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

        public void inserir(int elemento) {
            //precisa criar outro No
            No novo = new No();
            novo.setElemento(elemento); //Insere o elemento no No
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

        public void listar() {
            if (inicio == null) {
                Console.WriteLine("Lista Vazia");
            }
            else {
                No aux = inicio;
                while (aux != null) {
                    Console.WriteLine($"Elemento visto: {aux.getElemento()}");
                    aux = aux.getProximo();
                }
            }
        }

        public int retirar() {
            //Considera que a lista sempre tem elementos
            //Alguém na aplicação precisa, antes de remover, testar se a lista está vazia
            No aux = inicio;
            int elemento = aux.getElemento();
            inicio = aux.getProximo();
            return elemento;
        }

        public bool isEmpty() {
            return this.inicio == null;
        }
    }
}
