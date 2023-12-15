using Aysa14.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aysa14.Models
{
    public class AppDbContext: DbContext
    {
        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;

        //Tablas de base de datos
        public DbSet<Compra> People { get; set; }

        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        { 
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }


    }


}
