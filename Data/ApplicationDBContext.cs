using Employadmenportial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employadmenportial.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }

}
