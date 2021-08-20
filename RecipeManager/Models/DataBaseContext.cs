using RecipeManager.Models.DataBaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    class DataBaseContext : DbContext
    {
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<SellsHistoryEntry> history { get; set; }


        public DataBaseContext() : base("DefaultConnection") { }
    }
}
