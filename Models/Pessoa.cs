using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar()
        {
            //Nome = "Lucas";  exemplo de set, atribuindo um valor a Nome
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos"); // exemplo de get, pegando o valor {nome}
            // usar o caractere \n serve para uma quebra de linha 
        }
    }
}