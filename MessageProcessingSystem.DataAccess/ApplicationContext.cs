using MessageProcessingSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageProcessingSystem.DataAccess;

public class ApplicationContext : DbContext
{
    public DbSet<Employee> Employees { get; private set; } = null!;
    public DbSet<Employee> Managers { get; private set; } = null!;
    public DbSet<Message> Messages { get; private set; } = null!;
    public DbSet<Report> Reports { get; private set; } = null!;
    public DbSet<Source> Sources { get; private set; } = null!;
    public DbSet<Account> Accounts { get; internal set; } = null!;
    public DbSet<Admin> Admins { get; internal set; } = null!;
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
}