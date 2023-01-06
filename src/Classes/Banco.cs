namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Banco
    {
        private string tipoSangue { get; set; }
        private float qtdSangue { get; set; }

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
        }

        public void exibeBanco()
        {
            foreach (var key in estoqueSangues)
            {
                Console.WriteLine($"{key.Key} - {key.Value}");
            }
        }
    }
}