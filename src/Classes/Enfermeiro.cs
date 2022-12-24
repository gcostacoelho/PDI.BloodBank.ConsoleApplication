namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Enfermeiro : Pessoa
    {
        private string? corem { get; set; }

        public Enfermeiro(string nome, DateOnly DataNascimento, string registro)
        {
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.corem = registro;
        }

        public Doador cadastraDoador()
        {
            string? nome="", tipoSangue="", input="";
            DateOnly dataNascimento;
            float peso = 0;

            try
            {
                Console.WriteLine("Digite o nome do doador: ");
                input = Console.ReadLine();

                if (input != null)
                {
                    nome = input;
                }

                Console.WriteLine("Digite o tipo sanguineo do doador: ");
                input = Console.ReadLine();

                if (input != null)
                {
                    tipoSangue = input;
                }


                Console.WriteLine("Digite a data de nascimento do doador: ");
                input = Console.ReadLine();
                
                if (input != null)
                {
                    dataNascimento = DateOnly.Parse(input);
                }

                Console.WriteLine("Digite o peso do doador: ");
                input = Console.ReadLine();
                
                if (input != null)
                {
                    peso = float.Parse(input);
                }

                return new Doador(nome, dataNascimento, tipoSangue, peso);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                return new Doador();
            }
        }

    }
}