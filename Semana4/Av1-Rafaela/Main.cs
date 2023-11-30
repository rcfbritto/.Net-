using System.Security.Cryptography;
using Cliente = Teste.Cliente;

using Namespace;
public class Program
{
    public static void Main(string[] args){
        EscritorioAdvocacia escritorio = new EscritorioAdvocacia();

        Advogado advogado1 = new Advogado();
        {
        advogado1.nome = "Rafaela Brito";
        advogado1.DatadeNascimento = new DateTime(1994, 07, 23);
        advogado1.CPF = "123.456.789-00";
        advogado1.CNA = "123456789";
        };

        Cliente cliente1 = new Cliente();
        {
            cliente1.Nome = "Maria Ferreira";
            cliente1.DataDeNascimento = new DateTime(1957, 02, 08);
            cliente1.CPF = "123.456.789-00";
            cliente1.EstadoCivil = "Solteira";
            cliente1.Profissao = "Engenheira";
        };
        escritorio.AdicionarAdvogado(advogado1);
        escritorio.AdicionarCliente(cliente1);
    }
     public IEnumerable<Advogado> AdvogadosComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return advogados.Where(a => CalculaIdade(a.DataNascimento) >= idadeMinima && CalculaIdade(a.DataNascimento) <= idadeMaxima);
    }
    public IEnumerable<Cliente> ClientesComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return clientes.Where(c => CalculaIdade(c.DataNascimento) >= idadeMinima && CalculaIdade(c.DataNascimento) <= idadeMaxima);
    }
    public IEnumerable<Cliente> ClientesComEstadoCivil(string estadoCivil){
        return clientes.Where(c => c.EstadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<Cliente> ClientesEmOrdemAlfabetica()
    {
        return clientes.OrderBy(c => c.nome);
        
    }
    public IEnumerable<Cliente> ClientesComProfissao(string textoProfissao){
        return clientes.Where(c => c.Profissao.Contains(textoProfissao, StringComparison.OrdinalIgnoreCase));   
    }
    public IEnumerable<object> AniversariantesDoMes(int mes){
        return advogados.Concat<object>(clientes).Where(p => ((DateTime)p.GetType().GetProperty("DataNascimento").GetValue(p)).Month == mes)
            .OrderBy(p => ((DateTime)p.GetType().GetProperty("DataNascimento").GetValue(p)).Day);
    }
    private int CalculaIdade(DateTime dataNascimento){
        int idade = DateTime.Today.Year - dataNascimento.Year;
        if(DateTime.Today < dataNascimento.AddYears(idade)) idade--;
        return idade;
    }
}
