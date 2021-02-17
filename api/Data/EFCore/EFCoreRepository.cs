using System;
using System.Linq;
using System.Threading.Tasks;
using api.Repositories;

namespace api.Data.EFCore
{
  public class EFCoreRepository<TEntity> : IRepository<TEntity>
    where TEntity : class, new()
  {
    protected DataContext Context;

    public EFCoreRepository(DataContext context)
    {
      this.Context = context;
    }

    public IQueryable<TEntity> GetAll()
    {
      try
      {
        return Context.Set<TEntity>();
      }
      catch (Exception ex)
      {
        throw new Exception($"Couldn't retrieve entities: {ex.Message}");
      }
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
      if (entity == null)
      {
        throw new ArgumentException($"{nameof(AddAsync)} entity must be not null");
      }

      try
      {
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();

        return entity;
      }
      catch (Exception ex)
      {
        throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
      }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
      if (entity == null)
      {
        throw new ArgumentNullException($"{nameof(UpdateAsync)} entity must not be null");
      }

      try
      {
        Context.Update(entity);
        await Context.SaveChangesAsync();

        return entity;
      }
      catch (Exception ex)
      {
        throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
      }
    }

    public async Task<TEntity> DeleteAsync(int id)
    {
      var entity = await Context.Set<TEntity>().FindAsync(id);

      if (entity == null)
      {
        throw new ArgumentNullException($"{nameof(DeleteAsync)} entity must not be null");
      }

      Context.Remove(entity);
      await Context.SaveChangesAsync();

      return entity;
    }
  }
}