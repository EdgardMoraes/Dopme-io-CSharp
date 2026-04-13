using BibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //DbSets serão adicionados depois
    }

    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Livro>(e =>
        {
            e.ToTable("Livros");
            e.HasKey(l => l.Id);
            e.Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(100);
            e.Property(l => l.ISBN)
                .IsRequired()
                .HasMaxLength(20);
            e.Property(l => l.AnoPublicacao)
                .IsRequired()
                .HasMaxLength(4);
        });

        modelBuilder.Entity<Autor>(a =>
        {
            a.ToTable("Autores");
            a.HasKey(a => a.Id);
            a.Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(50);
            a.Property(a => a.DataNascimento)
                .IsRequired()
                .ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Categoria>(c =>
        {
            c.ToTable("Categorias");
            c.HasKey(c => c.Id);
            c.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);
            c.Property(c => c.Descricao)
                .HasMaxLength(100);
        });
        
        // Categoria -> Livro (1:N)
        modelBuilder.Entity<Livro>()
            .HasOne(l => l.Categoria)
            .WithMany(c => c.Livros)
            .HasForeignKey(l => l.CategoriaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Autor -> Livro (1:N)
        modelBuilder.Entity<Livro>()
            .HasOne(l => l.Autor)
            .WithMany(a => a.Livros)
            .HasForeignKey(l => l.AutorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}