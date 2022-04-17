//.... - - .--. ... ---... -..-. -..-. -.-- --- ..- - ..- .-.-.- -... . -..-. -.. .-- .--- -.-- .-.. --.. .... ----- .. -. --.-
using Microsoft.EntityFrameworkCore;
using WebAPI2.Models;

namespace WebAPI2.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options): base(options) { }

        public DbSet<Issue> Issues { get; set; }
    }
}
