using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Namespace;
public class Principal
{
    public static void Main(string[] args){
        EscritorioAdvocacia escritorio = new EscritorioAdvocacia();

        Advogado advogado1 = new Advogado();
        {
        advogado1.nome = "Rafaela Brito";
        advogado1.DataDeNascimento = new DateTime(1994, 07, 23);
        advogado1.CPF = "123.456.789-00";
        advogado1.CNA = "123456789";
        };

        Cliente cliente1 = new Cliente();
        {
            cliente1.nome = "Maria Ferreira";
            cliente1.DataDeNascimento = new DateTime(1957, 02, 08);
            cliente1.CPF = "123.456.789-00";
            cliente1.EstadoCivil = "Solteira";
            cliente1.Profissao = "Engenheira";
        };
        escritorio.AdicionarAdvogado(advogado1);
        escritorio.AdicionarCliente(cliente1);
    }
        Console.WriteLine("\nAdvogados com idade entre 30 e 50 anos: ");
        foreach (var advogado in escritorio.AdvogadosComIdadeEntre(30, 50))
        {
            Console.WriteLine($"{advogado.Nome} - {CalculaIdade(advogado.DataNascimento)} anos");
        }


}
