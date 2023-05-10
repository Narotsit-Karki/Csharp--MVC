using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{ 
    public interface IEDbcontext
    {
       
        DbSet<Brand> Brands { get; set; }

        DbSet<Category> Categories { get; set;}

        DbSet<TestModel> TestModels { get; set;}


    }
}
