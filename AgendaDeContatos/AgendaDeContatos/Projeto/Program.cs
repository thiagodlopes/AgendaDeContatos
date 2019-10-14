using System;
using System.Collections.Generic;

namespace ListaEncadeada {
    public class Program {
        public static void Main(string[] args) {

            var agenda = new HashSet<Contato>();

            Menu();

            void Menu() {

                bool mostrarMenu = true;

                while (mostrarMenu) {
                    mostrarMenu = MenuPrincipal();
                }

                bool MenuPrincipal() {

                    Console.Clear();
                    Console.WriteLine("1 - Criar contato");
                    Console.WriteLine("2 - Alterar dados de contato");
                    Console.WriteLine("3 - Excluir contato");
                    Console.WriteLine("4 - Limpar lista");
                    Console.WriteLine("5 - Gerar relatório de contatos");
                    Console.WriteLine("6 - Sair do programa");
                    Console.Write("\r\nSelecione uma opção: ");

                    switch (Console.ReadLine()) {

                        case "1": //Já tá OK
                            InserirContato();
                            Console.Clear();
                            return true;
                        case "2": //Já tá OK
                            AlterarContato();
                            Console.ReadLine();
                            return true;
                        case "3": //Faltando.
                            ExcluirContato();
                            Console.ReadLine();
                            return true;
                        case "4": //Depende do anterior, só usar foreach e retirar tudo.
                            //lista.retirar();
                            Console.ReadLine();
                            return true;
                        case "5": //Já tá OK
                            Console.Clear();
                            Console.WriteLine(ContarContatos());
                            ListarContatos();
                            Console.ReadLine();
                            //lista.listar();
                            return true;
                        case "6": //Já tá OK
                            return false;
                        default:
                            return true;

                    }

                }
                //Esse trecho é uma referência para o mecanismo a ser utilizado para a listagem dos contatos (Compare) para gerar em ordem alfabética
                /*LinkedList<No> Agenda = new LinkedList<No>();
                Agenda.inserir("");
                Console.WriteLine(Agenda.Contains("Teste"));
                Console.WriteLine(Agenda.Count);
                */

                /*string x = "a";
                string y = "b";
                if (string.Compare(x, y) < 0) { //0 = Primeiro vem antes
                    Console.WriteLine("X (A) vem primeiro");
                } else if(string.Compare(x, y) == 1){ //1 = São iguais
                    Console.WriteLine("São iguais");
                }
                else {
                    Console.WriteLine("Y (B) vem primeiro"); //>1 = Segunda vem antes
                }*/

                void InserirContato() {

                    Console.Write("\r\nNome: ");
                    string nome = Console.ReadLine();
                    Console.Write("\r\nData de nascimento (AAAA/MM/DD): ");
                    string nascimento = Console.ReadLine();
                    Console.Write("\r\nCpf: ");
                    string cpf = Console.ReadLine();
                    Console.Write("\r\nEndereço: ");
                    string endereco = Console.ReadLine();
                    Console.Write("\r\nTelefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("\r\nE-mail: ");
                    string eMail = Console.ReadLine();

                    var contato = new Contato(nome, nascimento, cpf, endereco, telefone, eMail);
                    agenda.Add(contato);

                }

                string ContarContatos() {

                    if (agenda.Count == 1) {
                        return ($"Há {agenda.Count} contato na sua agenda.");
                    }
                    else if (agenda.Count > 1) {
                        return ($"Há {agenda.Count} contatos na sua agenda.");
                    }
                    else {
                        return ("Não há contatos na agenda.");
                    }

                }

                void ListarContatos() {

                    foreach (Contato contato in agenda) {

                        Console.WriteLine();
                        Console.WriteLine($"Nome: {contato.Nome}");
                        Console.WriteLine($"Data de nascimento: {contato.DataDeNascimento}");
                        Console.WriteLine($"CPF: {contato.Cpf}");
                        Console.WriteLine($"Endereço: {contato.Endereco}");
                        Console.WriteLine($"Telefone: {contato.Telefone}");
                        Console.WriteLine($"E-mail: {contato.EMail}");

                    }

                }

                void AlterarContato() {

                    Console.WriteLine("Qual contato será alterado? ");
                    string alterar = Console.ReadLine();

                    foreach (Contato contato in agenda) {

                        if (contato.Nome == alterar) {

                            bool mostrarMenuAlterar = true;

                            while (mostrarMenuAlterar) {
                                mostrarMenuAlterar = MenuAlterar();
                            }

                            //Console.WriteLine($"Informe os novos dados para o {contato.Nome}.");
                            bool MenuAlterar() {
                                
                                Console.WriteLine($"Quais dados do contato '{contato.Nome}' devem ser alterados?");
                                Console.WriteLine("1 - Nome");
                                Console.WriteLine("2 - Data de nascimento");
                                Console.WriteLine("3 - CPF");
                                Console.WriteLine("4 - Endereço");
                                Console.WriteLine("5 - Telefone");
                                Console.WriteLine("6 - E-mail");
                                Console.WriteLine("7 - Cancelar");

                                switch (Console.ReadLine()) {
                                    case "1":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo nome para o contato '{contato.Nome}'");
                                        alterar = Console.ReadLine();
                                        contato.Nome = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        string resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "2":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo e-mail para o contato '{contato.Nome}'. O atual é: '{contato.DataDeNascimento}'");
                                        alterar = Console.ReadLine();
                                        contato.DataDeNascimento = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "3":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo CPF para o contato '{contato.Nome}'. O atual é: '{contato.Cpf}'");
                                        alterar = Console.ReadLine();
                                        contato.Cpf = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "4":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo endereço para o contato '{contato.Nome}'. O atual é: '{contato.Endereco}'");
                                        alterar = Console.ReadLine();
                                        contato.Endereco = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "5":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo telefone para o contato '{contato.Nome}'. O atual é: '{contato.Telefone}'");
                                        alterar = Console.ReadLine();
                                        contato.Telefone = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "6":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo e-mail para o contato '{contato.Nome}'. O atual é: '{contato.EMail}'");
                                        alterar = Console.ReadLine();
                                        contato.EMail = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = Console.ReadLine();

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "7":
                                        return false;

                                   default:
                                        return true;
                                }
                            }

                        } 

                    }

                }

                void ExcluirContato() {

                    Console.WriteLine("Qual contato será excluído? ");
                    string remover = Console.ReadLine();

                    foreach (Contato contatos in agenda) {

                        if (contatos.Nome == remover) {

                            Console.WriteLine($"O contato '{remover}' foi removido.");
                            if (contatos.Nome.Contains(remover)) {
                                agenda.Remove(contatos);
                                return;
                            }
                        }

                    }
                    
                    
                }
            }
        }
    }
}
