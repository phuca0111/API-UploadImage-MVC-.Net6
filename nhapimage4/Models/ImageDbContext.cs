using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nhapimage4.Model;

namespace nhapimage4.Models
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }

        public DbSet<ImageModel> Images { get; set; }

    }
}
