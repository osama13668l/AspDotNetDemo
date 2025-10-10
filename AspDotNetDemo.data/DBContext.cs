using AspDotNetDemo.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetDemo.data
{
    internal class DBContext : DbContext
    {
        public DBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constring = @"Server=.\SQLEXPRESS;Database=ASPDOTNETDEMO;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(constring);
        }
        public DbSet<User> Users { get; set; }
    }
}
