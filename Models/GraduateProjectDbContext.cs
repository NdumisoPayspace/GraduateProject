using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GraduateProject.Models;

public partial class GraduateProjectDbContext : DbContext
{


    public GraduateProjectDbContext(DbContextOptions<GraduateProjectDbContext> options)
        : base(options)
    {
    }

    public DbSet<Profile> Profile { get; set; }

}
