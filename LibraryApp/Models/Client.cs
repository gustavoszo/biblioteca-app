using System;

namespace LibraryApp.Models
{
    internal class Client
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public DateTime DateRegister { get; set; }

        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return "Nome: " + Name +
                "Documento: " + Document +
                "Telefone: " + Phone +
                "Email: " + Email +
                "Data de registro: " + DateRegister.ToString();
        }
    }
}
