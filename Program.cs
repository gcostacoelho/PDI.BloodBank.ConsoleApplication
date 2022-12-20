using PDI.BloodBank.ConsoleApplication.src.Classes;

namespace PDI.BloodBank.ConsoleApplication
{

    class Program
    {
        public static void Main(string[] args)
        {
            Doador d1 = new Doador();

            d1.cadastra();
            d1.exibeDadosDoador();
        }
    }
}