using System;

namespace ProjetoPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica { Nome = "Paulo", CPF = "12345678900", DataNascimento = new DateTime(2000, 5, 10), Renda = 5000.00, Logradouro = "Rua A", Numero = "123", Cidade = "São Sebatião ", Estado = "Distrito Federal", Cep = "12345678" };
            Console.WriteLine(pf.ValidarIdade() ? "Pessoa Física válida" : "Pessoa Física inválida");
            Console.WriteLine($"Imposto de Pessoa Física: {pf.PagarImposto():C2}");

            PessoaJuridica pj = new PessoaJuridica { Nome = "Empresa X", CNPJ = "12345678000199", RazaoSocial = "Empresa X Ltda", Faturamento = 20000.00, Logradouro = "Avenida B", Numero = "456", Cidade = "Brasilia", Estado = "DF", Cep = "98765432" };
            Console.WriteLine(pj.ValidarCNPJ() ? "Pessoa Jurídica válida" : "Pessoa Jurídica inválida");
            Console.WriteLine($"Imposto de Pessoa Jurídica: {pj.PagarImposto():C2}");
        }
    }
}

