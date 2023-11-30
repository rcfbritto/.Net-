namespace Namespace;
public class EscritorioAdvocacia
{
    private List<Advogado> advogados;
    private List<Cliente> clientes;
    
    advogados = new List<Advogado>();
    clientes = new List<Cliente>();
    
    public EscritorioAdvocacia()
    {
        advogados = new List<Advogado>();
        clientes = new List<Cliente>();
    }
    public void AdicionarAdvogado(Advogado advogado){
        if((advogados.Exists(a => a.CPF == advogado.CPF) || advogados.Exists(a => a.CNA == advogado.CNA)))
        {
            System.Console.WriteLine("Advogado com CPF ou CNA já cadastrado!");
        }
        else
        {
            advogados.Add();
            System.Console.WriteLine("Advogado adicionado com sucesso!");
        }
            
    }
}
