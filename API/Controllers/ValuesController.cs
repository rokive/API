using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repositories.Repositories;
using Repositorys.DBContext;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //public GenericRepository<Category> CategoryRepository
        //{
        //    get
        //    {
        //        if (this.categoryRepository == null)
        //        {
        //            this.categoryRepository = new GenericRepository<Category>(context);
        //        }
        //        return categoryRepository;
        //    }
        //}
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            GenericRepository<Category> categoryRepository = new GenericRepository<Category>(new ApiDbContext());
            long id = 2;
            categoryRepository.Delete(id);
            return categoryRepository.Get(null, null, null, null, null).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //GenericRepository<Category> categoryRepository = new GenericRepository<Category>(new ApiDbContext());
            //categoryRepository.Delete(id);
        }
    }
}
