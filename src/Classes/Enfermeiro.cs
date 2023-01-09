namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Enfermeiro : Pessoa
    {
        private string Corem { get; set; }

        private Banco banco = new Banco();

        public Enfermeiro(string nome, DateOnly DataNascimento, string registro)
        {
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.Corem = registro;
        }

        public Doador cadastraDoador()
        {
            DateOnly dataNascimento;
            string nome = "", tipoSangue = "", cpf = "", input;
            float peso = 0;

            try
            {
                // Get Nome
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

                // Get tipo sanguineo
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

                // Get data de nascimento
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

                // Get CPF
                do
                {
                    Console.WriteLine("Digite o CPF do doador: ");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        cpf = input;
                    }

                } while (input == "");

                Console.Clear();

                // Get Peso
                do
                {
                    Console.WriteLine("Digite o peso do doador: ");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        peso = float.Parse(input);
                    }

                } while (input == "");

                return new Doador(nome, dataNascimento, tipoSangue, peso, cpf);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }

        public void registraEntrada(Doador d1)
        {
            string input, cpf = "";

            do
            {
                Console.WriteLine("Digite o CPF do doador: ");
                input = Console.ReadLine();

                if (input != null)
                {
                    cpf = input;
                }

            } while (input == "");

            var doador = d1.procuraDoador(cpf);

            if (doador != null)
            {
                banco.entradaBanco(doador);
            }
            else
            {
                Console.WriteLine("Parece que não temos ninguém com esse CPF cadastrado... Por favor tente novamente");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void registraSaida()
        {
            Console.Clear();
            string tipoSangue = "", input;
            float qtdSangue = 0;

            do
            {
                Console.WriteLine("Informe o tipo sanguineo a ser retirado: ");
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

            do
            {
                Console.WriteLine("Informe a quantidade de sangue a ser retirado: ");
                input = Console.ReadLine();

                qtdSangue = float.Parse(input);

            } while (input == "");

            if (tipoSangue != "" && qtdSangue > 0)
            {
                banco.saidaBanco(tipoSangue, qtdSangue);
            }
        }

        public void verificaEstoque()
        {
            banco.defineSituacao();
        }
    }
}