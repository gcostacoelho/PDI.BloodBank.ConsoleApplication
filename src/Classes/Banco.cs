namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Banco
    {
        private string tipoSangue { get; set; }
        private float qtdSangue { get; set; }

        public Historico hist = new Historico();
        
        Dictionary<string, float> estoqueSangues = new Dictionary<string, float>()
        {
            { "A Positivo", 500 },
            { "A Negativo", 200 },

            { "B Positivo", 100 },
            { "B Negativo", 80 },

            { "AB Positivo", 200 },
            { "AB Negativo", 600 },

            { "O Positivo", 75 },
            { "O Negativo", 50 },
        };

        public void entradaBanco(Doador doador, float qtdSangue = 450)
        {
            foreach (var key in estoqueSangues)
            {
                if (key.Key == doador.TipoSanguineo)
                {
                    estoqueSangues[key.Key] = key.Value + qtdSangue;
                }
            }

            hist.adicionaEntradaHistorico(doador);
            hist.exibeHistorico();


            Console.WriteLine("Registro de entrada no banco feito;");
        }

        public void saidaBanco(string tipoSangue, float qtdSangueRetirado)
        {
            foreach (var key in estoqueSangues)
            {
                if (key.Key == tipoSangue)
                {
                    if (qtdSangueRetirado > key.Value)
                    {
                        Console.Clear();
                        Console.WriteLine("Quantidade de sangue requerida é maior do que a que está no banco");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        estoqueSangues[key.Key] = key.Value - qtdSangueRetirado;

                        Console.WriteLine("Retirado no banco feita");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }

        public void defineSituacao()
        {
            foreach (var key in estoqueSangues)
            {
                
                if (key.Value < 50)
                {
                    Console.WriteLine($"Tipo de Sangue - {key.Key}\nQuantidade - {key.Value}\nSituação - Baixo");
                }
                else if (key.Value == 50)
                {
                    Console.WriteLine($"Tipo de Sangue - {key.Key}\nQuantidade - {key.Value}\nSituação - Médio");
                }
                else if (key.Value > 50)
                {
                    Console.WriteLine($"Tipo de Sangue - {key.Key}\nQuantidade - {key.Value}\nSituação - Alto");
                }

                Console.WriteLine("------------------");
            }
        }
    }
}