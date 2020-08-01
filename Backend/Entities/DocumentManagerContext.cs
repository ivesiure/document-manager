using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DocumentManagerContext : DbContext
    {
        public DocumentManagerContext(DbContextOptions<DocumentManagerContext> options) : base(options) { }

        public DbSet<Document> Document { get; set; }

        public DbSet<DocumentMedia> DocumentMedia { get; set; }
    }
}