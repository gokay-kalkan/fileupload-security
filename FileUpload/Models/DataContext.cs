using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
