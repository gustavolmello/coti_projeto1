using Projeto01.Entities;
using Projeto01.Repositories;
using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Endereco = new Endereco();

            cliente.IdCliente = Guid.NewGuid();

            cliente.Endereco.IdEndereco = Guid.NewGuid();

            Console.Write("Informe o nome do cliente....: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe o Email do cliente...: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Informe o CPF do cliente......: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Informe a data de nascimento..: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe o logradouro..........:");
            cliente.Endereco.Logradouro = Console.ReadLine();
            
            Console.Write("Informe o numero..............:");
            cliente.Endereco.Numero = Console.ReadLine();

            Console.Write("Informe o bairro...............:");
            cliente.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe a cidade...............:");
            cliente.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe o estado...............:");
            cliente.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe o CEP..................:");
            cliente.Endereco.Cep = Console.ReadLine();

            Console.WriteLine("\nDADOS DO CLIENTE:\n");

            Console.WriteLine("Id do Cliente...........: " + cliente.IdCliente);
            Console.WriteLine("Nome do Cliente.........: " + cliente.Nome);
            Console.WriteLine("Email do Cliente........: " + cliente.Email);
            Console.WriteLine("CPF do Cliente..........: " + cliente.Cpf);
            Console.WriteLine("Data de Nascimento......: " + cliente.DataNascimento);

            Console.WriteLine("\nENDERECO DO CLIENTE:\n");

            Console.WriteLine("Id do endereco.........: " + cliente.Endereco.IdEndereco);
            Console.WriteLine("Logradouro.............: " + cliente.Endereco.Logradouro);
            Console.WriteLine("Numero.................: " + cliente.Endereco.Numero);
            Console.WriteLine("Bairro.................: " + cliente.Endereco.Bairro);
            Console.WriteLine("Cidade.................: " + cliente.Endereco.Cidade);
            Console.WriteLine("Estado.................: " + cliente.Endereco.Estado);
            Console.WriteLine("CEP....................: " + cliente.Endereco.Cep);

            try
            {
                var clienteRepository = new ClienteRepository();

                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("\nArquivo TXT gravado com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            Console.ReadKey();

            
        }
    }
}
