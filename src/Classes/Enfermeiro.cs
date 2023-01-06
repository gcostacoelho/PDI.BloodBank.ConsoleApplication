namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Enfermeiro : Pessoa
    {
        private string Corem { get; set; }

        public Enfermeiro(string nome, DateOnly DataNascimento, string registro)
        {
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.Corem = registro;
        }

        public Doador cadastraDoador()
        {
            DateOnly dataNascimento;
            string nome = "", tipoSangue = "", input;
            float peso = 0;

            try
            {
                do
                {
                    Console.WriteLine("Digite o nome do doador: ");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        nome = input;
                    }

                } while (input == "");

                Console.Clear();

                do
                {
                    Console.WriteLine("Informe o tipo sanguineo do doador: ");
                    Console.WriteLine("1 - A Positivo\n2 - A Negativo\n3 - B Positivo\n4 - B Negativo\n5 - AB Positivo\n6 - AB Negativo\n7 - O Positvo\n8 - O Negativo");

                    input = Console.ReadLine();

                    if (input != null)
                    {
                        switch (input)
                        {
                            case "1":
                                tipoSangue = "A Positivo";
                                break;
                            case "2":
                                tipoSangue = "A Negativo";
                                break;
                            case "3":
                                tipoSangue = "B Positivo";
                                break;
                            case "4":
                                tipoSangue = "B Negativo";
                                break;
                            case "5":
                                tipoSangue = "AB Positivo";
                                break;
                            case "6":
                                tipoSangue = "AB Negativo";
                                break;
                            case "7":
                                tipoSangue = "O Positivo";
                                break;
                            case "8":
                                tipoSangue = "O Negativo";
                                break;
                            default:
                                Console.WriteLine("Opção inválida, tente novamente");
                                break;
                        }
                    }
                } while (input == "");

                Console.Clear();

                do
                {
                    Console.WriteLine("Digite a data de nascimento do doador: ");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        dataNascimento = DateOnly.Parse(input);
                    }
                } while (input == "");

                Console.Clear();

                do
                {
                    Console.WriteLine("Digite o peso do doador: ");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        peso = float.Parse(input);
                    }

                } while (input == "");

                return new Doador(nome, dataNascimento, tipoSangue, peso);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                return new Doador(nome, dataNascimento, tipoSangue, peso);
            }
        }

    }
}