namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public abstract class Pessoa
    {
        protected String Nome { get; set; }
        protected DateOnly DataNascimento { get; set; }
    }
}