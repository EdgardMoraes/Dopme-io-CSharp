using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //DbSets serão adicionados depois
    }
}