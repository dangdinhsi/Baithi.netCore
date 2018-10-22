using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaithiASPdotNet22102018.Models;

namespace BaithiASPdotNet22102018.Models
{
    public class BaithiASPdotNet22102018Context : DbContext
    {
        public BaithiASPdotNet22102018Context (DbContextOptions<BaithiASPdotNet22102018Context> options)
            : base(options)
        {
        }

        public DbSet<BaithiASPdotNet22102018.Models.Category> Category { get; set; }

        public DbSet<BaithiASPdotNet22102018.Models.Product> Product { get; set; }
    }
}
