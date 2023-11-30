using System.Security.Cryptography;

namespace Namespace;
public class Program
{
    public static void Main(string[] args){
        EscritorioAdvocacia escritorio = new EscritorioAdvocacia();

        Advogado advogado1 = new Advogado();
        {
            nome = "Rafaela Brito";
            DatadeNascimento = new DateTime(1994, 07, 23);
            CPF = "123.456.789-00";
            CNA = "123456789";
        };
        Cliente cliente1 = new Cliente();
        {
            nome = "Maria Ferreira";
            DatadeNascimento = new DateTime(1957, 02, 08);
            CPf = "123.456.789-00";
            EstadoCivil = "Solteira";
            Profissao = "Engenheira";
        };
        escritorio.AdicionarAdvogado(advogado1);
        escritorio.AdicionarCliente(cliente1);
    }
}
