using System.Data.Entity;

namespace Study
{
    internal class war_worldDB : DbContext
    {
        public war_worldDB() : base("DBConnection")
        {
        }

        public DbSet<creature_template> Creature_Template { get; set; }
    }
}