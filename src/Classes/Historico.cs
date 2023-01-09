namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Historico
    {
        private Dictionary<string, List<Dictionary<string, string>>> historicoEntrada = new Dictionary<string, List<Dictionary<string, string>>>()
        {
            {
                "A Positivo", new List<Dictionary<string, string>>()
            },
            {
                "A Negativo", new List<Dictionary<string, string>>()
            },
            {
                "B Positivo", new List<Dictionary<string, string>>()
            },
            {
                "B Negativo", new List<Dictionary<string, string>>()
            },
            {
                "AB Positivo", new List<Dictionary<string, string>>()
            },
            {
                "AB Negativa", new List<Dictionary<string, string>>()
            },
            {
                "O Positivo", new List<Dictionary<string, string>>()
            },
            {
                "O Negativo", new List<Dictionary<string, string>>()
            }
        };

        public void exibeHistorico()
        {
            foreach (var item in historicoEntrada)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"{item.Key}:");
                    
                    foreach (var _item in item.Value[i])
                    {
                        Console.WriteLine($"\t{_item.Key}: {_item.Value}");
                        Console.WriteLine("-------------");
                    }
                }
            }
        }
    }
}