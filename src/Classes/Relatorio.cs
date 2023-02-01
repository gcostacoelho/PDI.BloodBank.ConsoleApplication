namespace PDI.BloodBank.ConsoleApplication.src.Classes
{
    public class Relatorio
    {
        public void doadoresCadastrados(Doador doador)
        {
            doador.exibeDadosDoador();
        }

        public void registros(Banco banco, String tipoHistorico)
        {
            banco.hist.exibeHistorico(tipoHistorico);
            Console.ReadKey();
        }
    }
}