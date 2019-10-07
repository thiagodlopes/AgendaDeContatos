using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos {
    public class No {
        private int elemento;   //Define o tipo de dado que o nó irá comportar
        private No proximo;     //Referencia a propria classe para apontar para o próximo elemento

        public void setElemento(int elemento) {
            this.elemento = elemento;
        }
        public int getElemento() {
            return this.elemento;
        }
        public void setProximo(No proximo) {
            this.proximo = proximo;
        }
        public No getProximo() {
            return this.proximo;
        }
    }
}



