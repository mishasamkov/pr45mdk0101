using Api_samkov.Model;
using System.Collections.Generic;
using System;

namespace Api_samkov.Context
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UsersContext()
        {
            Database.EnsureCreated();
            Users.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;" + "port=3307;" + "uid=root;" + "pwd=;" + "database=TaskManager", new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
