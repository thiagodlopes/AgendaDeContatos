using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos {
    public class No {
        private Contato dado;   //Define o tipo de dado que o nó irá comportar
        private No proximo;     //Referencia a propria classe para apontar para o próximo Dado

        public void setDado(Contato dado) {
            this.dado = dado;
        }
        public Contato getDado() {
            return this.dado;
        }
        public void setProximo(No proximo) {
            this.proximo = proximo;
        }
        public No getProximo() {
            return this.proximo;
        }
    }
}
