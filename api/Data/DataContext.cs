using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Entites;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppGames>? appGames { get; set; }
    }
}