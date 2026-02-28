using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CidatAPP.Domain.ValuesObjects
{
    public class Email
    {
        public string EnderecoEmail { get; set; }
        // Construtor reservado para o Values Object
        protected Email() { }
        //Construtor público para criar uma instância de Email
        public Email(string enderecoEmail)
        {
            if (string.IsNullOrWhiteSpace(enderecoEmail))
                throw new ArgumentException("Email é obrigatório");

            if (!IsValid(enderecoEmail))
                throw new ArgumentException("Email inválido");
            EnderecoEmail = enderecoEmail.ToLower();

        }
        private bool IsValid(string enderecoEmail)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(enderecoEmail);
        }
        public override string ToString() => EnderecoEmail ?? string.Empty;

    }
}
