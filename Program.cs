using PDI.BloodBank.ConsoleApplication.src.Classes;

namespace PDI.BloodBank.ConsoleApplication
{

    class Program
    {
        public static void Main(string[] args)
        {

            #region Testes
                Enfermeiro enfermeiroChefe = new Enfermeiro("Gustavo Costa", new DateOnly(2003, 05, 16), "0000011-01");

                Doador doador = enfermeiroChefe.cadastraDoador();

                Console.Clear();
                doador.exibeDadosDoador();
            #endregion

        }
    }
}