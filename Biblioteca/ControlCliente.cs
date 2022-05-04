using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlCliente
    {
        Cliente cliente = new Cliente(); //conectando a model e a control
        private int opcao;
        public ControlCliente()
        {
            cliente = new Cliente();
        } // fim do construtor

        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        } // fim opcao


        public void Menu()
        {
            Console.Clear(); // limpa a tela do console 
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n\n" +
                                      "1. Cadastrar\n"             +
                                      "2. Consultar\n"              +
                                      "3. Atualizar Nome\n"         +
                                      "4. Atualizar Telefone\n"     +
                                      "5. Atualizar Endereço\n"     +
                                      "6. Excluir\n"                +
                                      "0. Sair"                     );
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        } // fim do menu

        public void Executar()
        {
            do { 
                    Menu();

                // executar ação

                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;


                    case 1: // cadastrar usuario
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um endereço: ");
                        string endereco = Console.ReadLine();
                        cliente.Cadastrar(codigo, nome, telefone, endereco); // passei o dado por parametro para o método
                        Console.WriteLine("Cadastro efetuado com sucesso"); // mostro o dado em tela
                        break;

                    case 2: // consultar usuario 
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.Consultar(codigo));
                        Console.ReadLine(); // manter o prompt aberto
                        break;


                    case 3: // atualizar nome de usuario 
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarNome(codigo, nome));
                        break;

                    case 4: // atualizar telefone de usuario 
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um telefone: ");
                        telefone = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarTelefone(codigo, telefone));
                        break;

                    case 5: // atualizar endereço de usuario 
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um endereco: ");
                        endereco = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarNome(codigo, endereco));
                        break;

                    case 6:
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.Excluir(codigo));
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida! Tente novamente!");
                        break;
                } // fim switch
            } while (AcessarOpcao != 0) ; // fim do 
            
           


        } // fim executar



    } // fim da control
} // fim do projeto 
