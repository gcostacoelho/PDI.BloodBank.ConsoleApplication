using PDI.BloodBank.ConsoleApplication.src.Classes;

namespace PDI.BloodBank.ConsoleApplication
{

    class Program
    {
        public static void Main(string[] args)
        {
            Doador d1 = new Doador();
            Enfermeiro e1 = new Enfermeiro("Gustavo Costa", new DateOnly(2003, 05, 16), "0000011-01");

            e1.cadastraDoador();
            
            d1.exibeDadosDoador();
        }
    }
}