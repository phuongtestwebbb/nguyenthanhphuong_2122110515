using Microsoft.EntityFrameworkCore;
using nguyenthanhphuong_2122110515.Model;
using System.Collections.Generic;


namespace nguyenthanhphuong_2122110515
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}