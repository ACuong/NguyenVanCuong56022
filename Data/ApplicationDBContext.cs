using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVanCuong56022;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenVanCuong56022.UniversityNVC56022> UniversityNVC56022 { get; set; }

        public DbSet<NguyenVanCuong56022.NVC056022> NVC056022 { get; set; }
    }
