using Microsoft.EntityFrameworkCore;

namespace codeSnippets.Models
{
    public class SnippetContext : DbContext
    {
        public SnippetContext (DbContextOptions<SnippetContext> options)
            : base(options)
        {
        }

        public DbSet<codeSnippets.Models.Snippet> Snippet { get; set; }
    }
}