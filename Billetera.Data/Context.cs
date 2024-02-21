using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera.Data
{
    public partial class Context
    {
        public string _connectionString;


        public Context(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=DESKTOP-T2I28GR\\\\SQLEXPRESS;Database=Inmobiliaria;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }


    }
}
