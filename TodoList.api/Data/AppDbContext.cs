using Microsoft.EntityFrameworkCore;
using TodoList.api.Models;

namespace TodoList.api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) {}

    public DbSet<Todo> Todos { get; set; }
}
