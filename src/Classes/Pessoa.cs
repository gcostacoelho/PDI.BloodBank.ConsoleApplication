namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public abstract class Pessoa
    {
        public String Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string cpf { get; set; }
    }
}