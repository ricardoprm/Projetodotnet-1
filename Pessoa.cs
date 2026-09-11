using System;

namespace ProjetoPratico
{
    public class PessoaFisica
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public double Renda { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;

        public bool ValidarIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DataNascimento.Date > DateTime.Now.AddYears(-idade)) idade--;
            return idade >= 18;
        }

        public double PagarImposto()
        {
            return Renda * 0.03;
        }

        public double PagarImposto(double renda)
        {
            return renda * 0.03;
        }
    }
    public class PessoaJuridica
    {
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public double Faturamento { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;

        public bool ValidarCNPJ()
        {
            return CNPJ.Length == 14 && CNPJ.Substring(8, 4) == "0001";
        }

        public double PagarImposto()
        {
            return Faturamento * 0.05;
        }

        public double PagarImposto(double faturamento)
        {
            return faturamento * 0.05;
        }
    }
}
