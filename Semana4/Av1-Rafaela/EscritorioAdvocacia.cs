namespace Namespace;
public class EscritorioAdvocacia
{
        protected List<Advogado> advogados = new List<Advogado>();
        protected List<Cliente> clientes = new List<Cliente>();

    public void AdicionarAdvogado(Advogado advogado){
        if(advogados.Exists(x => x.CPF == advogado.CPF|| x.CNA == advogado.CNA))  
        {
            System.Console.WriteLine("Advogado com CPF ou CNA já cadastrado!");
        }
        else
        {
            advogados.Add(advogado);
            System.Console.WriteLine("Advogado adicionado com sucesso!");
        }      
    }
    public void AdicionarCliente(Cliente cliente){
        if(clientes.Exists(x => x.CPF == cliente.CPF))
        {
            System.Console.WriteLine("Cliente com CPF já cadastrado!");
        }
        else{
            clientes.Add(cliente);
        }
    }
    public void RemoverAdvogado(Advogado advogado){
        if(!advogados.Exists(x => x.CPF == advogado.CPF || x.CNA == advogado.CNA)){
            System.Console.WriteLine("Advogado não encontrado!");
        }
        else{
             advogados.Remove(advogado);
        }
    }
    public void RemoverCliente(Cliente cliente){
        if(!clientes.Exists(x => x.CPF == cliente.CPF)){
            System.Console.WriteLine("Cliente não encontrado!");
        }
        else{
             clientes.Remove(cliente);
        }   
    }

     public IEnumerable<Advogado> AdvogadosComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return advogados.Where(a => CalculaIdade(a.DataDeNascimento) >= idadeMinima && CalculaIdade(a.DataDeNascimento) <= idadeMaxima);
    }
    public IEnumerable<Cliente> ClientesComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return clientes.Where(c => CalculaIdade(c.DataDeNascimento) >= idadeMinima && CalculaIdade(c.DataDeNascimento) <= idadeMaxima);
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
