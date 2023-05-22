using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Services
{
    public class BrandServices: IBrandServices
    {
        private readonly IEDbcontext _dbcontext;
        public BrandServices(IEDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

     
    
        public async Task<List<Brand>> ListBrandsAsync(CancellationToken cancellationtoken)
        {
            var brands = await _dbcontext.Brands.ToListAsync(cancellationtoken);
            return brands;

        }
     

        public async Task<int> CreateBrandsAsync(Brand brand,CancellationToken cancellationtoken)
        {
            if (brand != null)
            {
                _dbcontext.Brands.Add(brand);
                await _dbcontext.SaveChangesAsync(cancellationtoken);

                return brand.Id;
            }
            return -1;
            
        }
    }
}
