
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;

namespace EFCoreBLL
{
    public class AddressBookContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
