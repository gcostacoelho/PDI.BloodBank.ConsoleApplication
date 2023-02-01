using PDI.BloodBank.ConsoleApplication.src.Classes;

namespace PDI.BloodBank.ConsoleApplication
{

    class Program
    {
        public static void Main(string[] args)
        {
            Doador doador = new Doador();
            Banco banco = new Banco();
            Relatorio relatorio = new Relatorio();
            Enfermeiro enfermeiroChefe = new Enfermeiro("Gustavo Costa", new DateOnly(2003, 05, 16), "0000011-01");

            do
            {
                Console.Clear();
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("0 - Encerrar\n1 - Cadastrar novo doador\n2 - Registrar entrada\n3 - Registrar saida\n4 - Verificar estoque\n5 - Obter relatórios");

                int input = int.Parse(Console.ReadLine());
                banco = enfermeiroChefe.banco;

                if (input == 0)
                {
                    Console.WriteLine("Até mais");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                switch (input)
                {
                    case 1:
                        doador.adicionaDoadorNaLista(enfermeiroChefe.cadastraDoador());

                        Console.ReadKey();
                        break;
                    case 2:
                        enfermeiroChefe.registraEntrada(doador);

                        Console.ReadKey();
                        break;
                    case 3:
                        enfermeiroChefe.registraSaida();

                        Console.ReadKey();
                        break;
                    case 4:
                        enfermeiroChefe.verificaEstoque();

                        Console.ReadKey();
                        break;
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------MENU-------");
                            Console.WriteLine("O que você deseja fazer?");
                            Console.WriteLine("0 - Voltar\n1 - Ver doadores cadastrados\n2 - Ver registros de entrada\n3 - Ver registros de saída");

                            int inputRelatorio = int.Parse(Console.ReadLine());

                            if (inputRelatorio == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (inputRelatorio == 1)
                            {
                                relatorio.doadoresCadastrados(doador);
                            }
                            else if (inputRelatorio == 2)
                            {
                                relatorio.registros(banco, "entrada");
                            }
                            else if (inputRelatorio == 3)
                            {
                                relatorio.registros(banco, "saida");
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.ReadKey();
                            }

                        } while (true);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja fazer mais alguma coisa?\n1 - Sim\n2 - Não");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                {
                    Console.WriteLine("Até mais");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

            } while (true);
        }
    }
}