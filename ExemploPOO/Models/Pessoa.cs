using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }

        public int Idade{get; set; }
        public void Apresenta()
        {
            console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}