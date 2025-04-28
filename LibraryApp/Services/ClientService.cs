using LibraryApp.Data;
using LibraryApp.Exceptions;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryApp.Services
{
    internal class ClientService
    {
        private readonly AppDbContext _dbContext;

        public ClientService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateClient(Client client)
        {
            if (FindClientByDocument(client.Document) != null)
                throw new ClientValidationException($"O documento {client.Document} já está cadastrado");

            if(FindClientByEmail(client.Email) != null)
                throw new ClientValidationException($"O email {client.Email} já está cadastrado");

            _dbContext.Clients.Add(client);
            Commit();
        }

        public Client? FindClientByDocument(string document)
        {
            return _dbContext.Clients.AsNoTracking().FirstOrDefault(c => c.Document == document);
        }

        public Client? FindClientByEmail(string email)
        {
            return _dbContext.Clients.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }


        private void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
