using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    public class ClienteRepository
    {
        public void ExportarDados(Cliente cliente)
        {
            var streamWriter = new StreamWriter("c:\\temp\\clientes.txt", true);

            streamWriter.WriteLine("Id Cliente.....: " + cliente.IdCliente);
            streamWriter.WriteLine("Nome...........: " + cliente.Nome);
            streamWriter.WriteLine("Emnail.........: " + cliente.Email);
            streamWriter.WriteLine("CPF............: " + cliente.Cpf);
            streamWriter.WriteLine("Data Nasc......: " + cliente.DataNascimento);
            streamWriter.WriteLine("\tId Endereco....: " + cliente.Endereco.IdEndereco);
            streamWriter.WriteLine("\tLogradouro.....: " + cliente.Endereco.Logradouro);
            streamWriter.WriteLine("\tNumero.........: " + cliente.Endereco.Numero);
            streamWriter.WriteLine("\tBairro.........: " + cliente.Endereco.Bairro);
            streamWriter.WriteLine("\tCidade.........: " + cliente.Endereco.Cidade);
            streamWriter.WriteLine("\tEstado.........: " + cliente.Endereco.Estado);
            streamWriter.WriteLine("\tCEP............: " + cliente.Endereco.Cep);
           
            streamWriter.WriteLine("\n");

            streamWriter.Close();
        }  
    }
}
