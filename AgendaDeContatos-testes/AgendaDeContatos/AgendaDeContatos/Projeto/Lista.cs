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
        //-------------------------------------Inserir dados de cadastro
        public void inserir(string nome, string dataDeNascimento, string endereco, string cpf, string telefone, string eMail) { //Ver como ficacom os vários tipos de dado
            //precisa criar outro No
            No novo = new No();
            //Começa a inserir as informações
            novo.setNome(nome); 
            novo.setNascimento(dataDeNascimento); 
            novo.setEndereco(endereco);
            novo.setCpf(cpf);
            novo.setTelefone(telefone);
            novo.setEMail(eMail);
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
                        Console.WriteLine($"Nome: {aux.getNome()}");   
                        Console.WriteLine($"Data de nascimento: {aux.getNascimento()}");
                        Console.WriteLine($"Endereço: {aux.getEndereco()}");
                        Console.WriteLine($"CPF: {aux.getCpf()}");
                        Console.WriteLine($"Telefone: {aux.getTelefone()}");
                        Console.WriteLine($"E-mail: {aux.getEMail()}");
                        aux = aux.getProximo();
                }
            }
        }

        public string retirar() { //Precisa consultar
            //Considera que a lista sempre tem dados
            //Alguém na aplicação precisa, antes de remover, testar se a lista está vazia
            No aux = inicio;
            string nome = aux.getNome();
            inicio = aux.getProximo();
            return nome;
        }

        public bool isEmpty() {
            return this.inicio == null;
        }
    }
}
