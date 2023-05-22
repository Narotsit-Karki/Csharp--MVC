using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.Persistence
{
    public class EDbcontext : DbContext, IEDbcontext
    {
        public EDbcontext(DbContextOptions<EDbcontext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }   
        public DbSet<Brand> Brands {get; set;}
        public DbSet<Category> Categories {get; set;}

        public DbSet<TestModel> TestModels { get; set;}

        public Task<int> SavChangesAsync(CancellationToken cancellationtoken)
        {
            return  base.SaveChangesAsync(cancellationtoken);
        }
        public int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
