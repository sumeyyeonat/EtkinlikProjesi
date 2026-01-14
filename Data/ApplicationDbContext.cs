using Microsoft.EntityFrameworkCore;
using EtkinlikSistemi.Models; // Modellerine erişmek için

namespace EtkinlikSistemi.Data;

public class ApplicationDbContext : DbContext
{
    // Bu yapı, veritabanı ayarlarını (bağlantı adresi gibi) dışarıdan almamızı sağlar
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    // Bu satır, "Event" modelimizi veritabanında "Events" tablosuna dönüştürür
    public DbSet<Event> Events { get; set; }
}