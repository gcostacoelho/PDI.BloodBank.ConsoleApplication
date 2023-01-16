namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Doador : Pessoa
    {
        private List<Doador> doadores = new List<Doador>();
        public String TipoSanguineo { get; private set; }
        private float Peso { get; set; }

        public Doador() { }

        public Doador(string nome, DateOnly dataNascimento, string tipoSangue, float peso, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.cpf = cpf;
            this.TipoSanguineo = tipoSangue;
            this.Peso = peso;
        }

        public void adicionaDoadorNaLista(Doador doador)
        {
            doadores.Add(doador);
            Console.WriteLine("Doador cadastrado com sucesso");
        }

        public Doador procuraDoador(string cpf)
        {
            foreach (var doador in doadores)
            {
                if (doador.cpf == cpf)
                {
                    return doador;
                }
            }
            return default;
        }

        public void exibeDadosDoador()
        {
            foreach (var doador in doadores)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"Nome - {doador.Nome}\nData de nascimento - {doador.DataNascimento.ToString("dd/MM/yyyy")}\nCPF - {doador.cpf}\nTipo sanguineo - {doador.TipoSanguineo}\nPeso - {doador.Peso} KG");
            }
        }

    }
}