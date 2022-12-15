using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Doador : Pessoa
    {
        private String? TipoSanguineo { get; set; }
        private float Peso { get; set; }

        public void cadastra()
        {
            Nome = "Gustavo";
            DataNascimento = new DateTime(2003, 05, 16);
            TipoSanguineo = "O-";
            Peso = 70;
        }

        public void exibeDadosDoador()
        {
            Console.WriteLine($"Nome - {Nome}\nData de nascimento - {DataNascimento}\nTipo sanguineo - {TipoSanguineo}\nPeso - {Peso}Kg");
        }

    }
}