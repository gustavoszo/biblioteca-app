using System;

namespace LibraryApp.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublishYear { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public int Total { get; set; }
        public int QuantityAvailable { get; set; }
        public DateTime DateRegister { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, " +
           $"Title: {Title}, " +
           $"Author: {Author}, " +
           $"Publisher: {Publisher}, " +
           $"Publish Year: {PublishYear}, " +
           $"ISBN: {ISBN}, " +
           $"Genre: {Genre}, " +
           $"Total: {Total}, " +
           $"Quantity Available: {QuantityAvailable}, ";
        }
    }

}
