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
}
