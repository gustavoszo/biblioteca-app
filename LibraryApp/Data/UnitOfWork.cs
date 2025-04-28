using System;
using LibraryApp.Security;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    internal static class UnitOfWork
    {
        private static AppDbContext _dbContext { get; set; }

        public static AppDbContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    var connectionString = DbSecurity.LoadDatabaseConfig().BuildConnectionString();
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                    _dbContext = new AppDbContext(optionsBuilder.Options);

                    return _dbContext;
                }
                return _dbContext;
            }
        }
    }
}
