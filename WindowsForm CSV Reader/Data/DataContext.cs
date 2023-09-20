using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_CSV_Reader.Models;

namespace WindowsForm_CSV_Reader.Database
{
    public class DataContext : DbContext
    {
        public DbSet<DataModel> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4TJ34MU;  Initial Catalog=ItemsDb; Integrated Security=True; Trusted_Connection=True;Encrypt=True; TrustServerCertificate=True;");
        }
    }
}
