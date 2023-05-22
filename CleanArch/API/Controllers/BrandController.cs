using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Application.Interfaces;
using NuGet.Protocol;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandServices brandServices;

        // GET: api/<BrandController>
        [HttpGet]
        public IEnumerable<Brand> Get()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellationtoken = tokenSource.Token;
            var brands_list = brandServices.ListBrandsAsync(cancellationtoken);
            return (IEnumerable<Brand>)brands_list;

        }

        // GET api/<BrandController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BrandController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BrandController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BrandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
