using System.Data.Entity;

namespace WoodArt.DAL
{
   public class WoodArtContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
