﻿using PDI.BloodBank.ConsoleApplication.src.Classes;

namespace PDI.BloodBank.ConsoleApplication
{

    class Program
    {
        public static void Main(string[] args)
        {
            Doador doador = new Doador();
            Enfermeiro enfermeiroChefe = new Enfermeiro("Gustavo Costa", new DateOnly(2003, 05, 16), "0000011-01");

            do
            {
                Console.Clear();
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("0 - Encerrar\n1 - Cadastrar novo doador\n2 - Registrar entrada\n3 - Registrar saida\n4 - Verificar estoque\n5 - Obter relatórios");

                int input = int.Parse(Console.ReadLine());

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
                        doador.addDoadorToList(enfermeiroChefe.cadastraDoador());
                        Console.Clear();
                        doador.exibeDadosDoador();
                        break;
                    case 2:
                        // Registra entrada
                        break;
                    case 3:
                        // Registra Saida
                        break;
                    case 4:
                        // Verifica estoque
                        break;
                    case 5:
                        // Obtem relatórios
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
                Console.Clear();
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