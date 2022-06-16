using DotnetEcommerceWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetEcommerceWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
