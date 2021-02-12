using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data.Interfaces;
using api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public abstract class ApiBaseController<TEntity, TRepository> : ControllerBase
      where TEntity : class, IEntity
      where TRepository : IRepository<TEntity>
  {
    private readonly TRepository repository;

    public ApiBaseController(TRepository repository)
    {
      this.repository = repository;
    }


    // GET: api/[controller]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> Get()
    {
      return await repository.GetAll();
    }

    // GET: api/[controller]/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TEntity>> Get(int id)
    {
      var data = await repository.Get(id);

      if (data == null)
      {
        return NotFound();
      }

      return data;
    }

    // PUT: api/[controller]/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TEntity data)
    {
      if (id != data.Id)
      {
        return BadRequest();
      }

      await repository.Update(data);

      return NoContent();
    }

    // POST: api/[controller]
    [HttpPost]
    public async Task<ActionResult<TEntity>> Post(TEntity data)
    {
      await repository.Add(data);

      return CreatedAtAction("Get", new { id = data.Id }, data);
    }

    // DELETE: api/[controller]/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<TEntity>> Delete(int id)
    {
      var data = await repository.Delete(id);

      if (data == null)
      {
        return NotFound();
      }

      return data;
    }

  }
}