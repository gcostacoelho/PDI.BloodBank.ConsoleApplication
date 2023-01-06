namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Doador : Pessoa
    {
        private String? TipoSanguineo { get; set; }
        private float Peso { get; set; }
        
        public Doador(string nome, DateOnly dataNascimento, string tipoSangue, float peso)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.TipoSanguineo = tipoSangue;
            this.Peso = peso;
        }

        public void exibeDadosDoador()
        {
            Console.WriteLine($"Nome - {Nome}\nData de nascimento - {DataNascimento}\nTipo sanguineo - {TipoSanguineo}\nPeso - {Peso} KG");
        }

    }
}