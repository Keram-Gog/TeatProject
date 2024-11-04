using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using WebApplication3.Models;
//Реализация была упрощена,
//и взаимодействия с данными описываются в контроллере,
//чтобы избежать чрезмерно объемного и "дублирующегося" кода.
namespace WebApplication3.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
