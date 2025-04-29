using System;

namespace LibraryApp.Models
{
    internal class Loan
    {
        public int Id { get; set; }

        public string DocumentClient { get; set; }
        public Client Client { get; set; }

        public DateTime DateLoan { get; set; }
        public DateTime ReturnDate { get; set; }

        public bool Returned { get; set; }    

        public ICollection<LoanBook> LoanBooks { get; set; } = new List<LoanBook>();

        public override string ToString()
        {
            return "Id: " + Id +
                "\nclient: " + DocumentClient;
        }
    }
}
