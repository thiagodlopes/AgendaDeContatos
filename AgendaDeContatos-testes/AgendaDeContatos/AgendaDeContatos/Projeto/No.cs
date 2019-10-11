using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos {
    public class No {
        public string nome;
        public string dataDeNascimento;
        public string endereco;
        public string cpf;
        public string telefone;
        public string eMail;   //Define o tipo de dado que o nó irá comportar
        private No proximo;     //Referencia a propria classe para apontar para o próximo Dado

        //---------------Get & Set Nome
        public void setNome(string nome) {
            this.nome = nome;
        }
        public string getNome() {
            return this.nome;
        }
        //---------------Get & Set Nascimento
        public void setNascimento(string dataDeNascimento) {
            this.dataDeNascimento = dataDeNascimento;
        }
        public string getNascimento() {
            return this.dataDeNascimento;
        }
        //---------------Get & Set Endereco
        public void setEndereco(string endereco) {
            this.endereco = endereco;
        }
        public string getEndereco() {
            return this.endereco;
        }
        //---------------Get & Set CPF
        public void setCpf(string cpf) {
            this.cpf = cpf;
        }
        public string getCpf() {
            return this.cpf;
        }
        //---------------Get & Set Telefone
        public void setTelefone(string telefone) {
            this.telefone = telefone;
        }
        public string getTelefone() {
            return this.telefone;
        }
        //---------------Get & Set E-mail
        public void setEMail(string eMail) {
            this.eMail = eMail;
        }
        public string getEMail() {
            return this.eMail;
        }
        //---------------Get & Set Próximo
        public void setProximo(No proximo) {
            this.proximo = proximo;
        }
        public No getProximo() {
            return this.proximo;
        }
    }
}
