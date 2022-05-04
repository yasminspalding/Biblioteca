using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cliente
    {
        // Declarar as variáveis;
        private int codigo;
        private string nomeCompleto;
        private string telefone;
        private string endereco;


        public Cliente()
        {
            // instanciando as variáveis
            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarEndereco = "";

        } // fim do método construtor;


        // Desenvolver os métodos gets e sets;

        public int AcessarCodigo
        {
            get
            {
                return codigo;

            } // fim set;

            set
            {
               this.codigo = value;

            } // fim get;

        } // fim do método de acesso de código;

        public string AcessarNome
        {
            get
            {
                return nomeCompleto;

            } // fim set;

            set
            {
                this.nomeCompleto = value;

            } // fim get;

        } // fim do AcessarNome;

        public string AcessarTelefone
        {
            get
            {
                return telefone;

            } // fim set;

            set
            {
                this.telefone = value;

            } // fim get;

        } // fim do AcessarTelefone;

        public string AcessarEndereco
        {
            get
            {
                return endereco;

            } // fim set;

            set
            {
                this.endereco = value;

            } // fim get;

        } // fim do AcessarEndereco;
        
        public void Cadastrar(int codigo, string nome, string telefone, string endereco)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;

        } // fim do método cadastrar;

        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                       "/nNome Completo: " + AcessarNome +
                       "/nTelefone: " + AcessarTelefone +
                       "/nEndereço: " + AcessarEndereco;

            } // fim if;

            else
            {
                return "Código Informado Não é Válido!";

            } // fim else;

        } // fim do método consultar;

        public string AtualizarNome(int codigo, string nome)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNome = nome;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código Informado Não é Válido!";
            }
       } // fim do método AtualizarNome;

        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código Informado Não é Válido!";
            }
        } // fim do método AtualizarTelefone;

        public string AtualizarEndereco(int codigo, string endereco)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEndereco = endereco;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código Informado Não é Válido!";
            }
        } // fim do método AtualizarEndereco;

        public string Excluir(int codigo)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                return "Dados excluidos com sucesso!";

            } // fim if;

            else
            {
                return "Código Informado Não é Válido!";

            } // fim else;
        } // fim do excluir


































    } // fim class
} //fim projeto
