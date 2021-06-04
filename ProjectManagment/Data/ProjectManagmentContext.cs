using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagment.Models;

    public class ProjectManagmentContext : DbContext
    {
        public ProjectManagmentContext (DbContextOptions<ProjectManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectManagment.Models.Developer> Developers { get; set; }
        public DbSet<ProjectManagment.Models.Project> Projects { get; set; }
        public DbSet<ProjectManagment.Models.Assignment> Assignment { get; set; }
        
    
    }
