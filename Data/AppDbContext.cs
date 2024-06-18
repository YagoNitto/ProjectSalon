using Microsoft.EntityFrameworkCore;
using ProjectSalonV2.Models;

namespace ProjectSalonV2.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Agendamento> Agendamentos { get; set; }
}
