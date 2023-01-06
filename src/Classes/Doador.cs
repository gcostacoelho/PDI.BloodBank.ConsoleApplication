namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Doador : Pessoa
    {
        List<Doador> doadores = new List<Doador>();
        private String TipoSanguineo { get; set; }
        private float Peso { get; set; }

        public Doador() { }

        public Doador(string nome, DateOnly dataNascimento, string tipoSangue, float peso)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.TipoSanguineo = tipoSangue;
            this.Peso = peso;
        }

        public void addDoadorToList(Doador doador)
        {
            doadores.Add(doador);
        }

        public void exibeDadosDoador()
        {
            foreach (var doador in doadores)
            {
                Console.WriteLine($"Nome - {doador.Nome}\nData de nascimento - {doador.DataNascimento.ToString("dd/MM/yyyy")}\nTipo sanguineo - {doador.TipoSanguineo}\nPeso - {doador.Peso} KG");
            }
        }

    }
}