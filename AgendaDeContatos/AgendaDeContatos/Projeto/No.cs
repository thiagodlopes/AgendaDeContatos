using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos {
    public class No {
        private contato dado;   //Define o tipo de dado que o nó irá comportar
        private No proximo;     //Referencia a propria classe para apontar para o próximo Dado

        public void setDado(contato dado) {
            this.dado = dado;
        }
        public contato getDado() {
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
