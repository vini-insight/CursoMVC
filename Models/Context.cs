using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=root;charset=utf8;");
        }
    }
}