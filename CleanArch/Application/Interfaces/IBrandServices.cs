using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IBrandServices
    {
        public Task<List<Brand>> ListBrandsAsync(CancellationToken cancellationtoken);
        public Task<int> CreateBrandsAsync(Brand brand, CancellationToken cancellationtoken);

    }
}
