using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;

namespace ProjectManagement.Data
{
    public class ProjectManagementContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> Categories { get; set; }
        public ProjectManagementContext(DbContextOptions<ProjectManagementContext> options) : base
        (options){}



        


    }
}
