using Api_samkov.Model;
using System.Collections.Generic;
using System;

namespace Api_samkov.Context
{
    public class TaskContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }

        public TaskContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql("server=localhost;" + "port=3307;" + "uid=root;" + "pwd=;" + "database=TaskManager",
                new MySqlServerVersion(new Version(8, 0, 11)));
    }
}
