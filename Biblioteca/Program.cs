using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCliente control = new ControlCliente(); // conectando a classe cliente
            control.Executar(); // usando o metodo executar
            Console.ReadLine(); // manter o prompt aberto 

        } // fim do método main
    } // fim da classe
} // fim do projeto 
