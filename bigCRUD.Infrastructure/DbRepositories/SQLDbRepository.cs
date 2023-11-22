
using bigCRUD.Application.Models;

using Microsoft.EntityFrameworkCore;



namespace bigCRUD.Infrastructure.DbRepositories
{
    public class SQLDbRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public SQLDbRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<T>> Create(T entity)
        {
            try
            {
                var _entity = _context.Set<T>();
                _entity.Add(entity);
                await _context.SaveChangesAsync();


                return new Response<T>(entity, "Created successfully");
            }
            catch (Exception ex)
            {
                // Handle any exceptions or log errors here
                return new Response<T>(default, ex.Message); // Return a response with the error message
            }
        }


        public async Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(id);
                if (entity != null)
                {
                    _context.Set<T>().Remove(entity);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new Response<bool>(true, "Deleted successfully");
                }
                else
                {
                    return new Response<bool>(false, "Entity not found");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions or log errors here
                return new Response<bool>(false, ex.Message); // Return a response with the error message
            }
        }


        public async Task<Response<List<T>>> GetAll()
        {

            var list = await _context.Set<T>().ToListAsync();
            return new Response<List<T>>(list);


        }

        public async Task<Response<T>> GetById(int objectId, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(objectId);
                if (entity != null)
                {
                    return new Response<T>(entity, "Entity found");
                }
                else
                {
                    return new Response<T>(default, "Entity not found");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions or log errors here
                return new Response<T>(default, ex.Message); // Return a response with the error message
            }
        }

        public async Task<Response<bool>> Update(T entity, CancellationToken cancellationToken)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync(cancellationToken);
                return new Response<bool>(true, "Updated successfully");
            }
            catch (Exception ex)
            {
                // Handle any exceptions or log errors here
                return new Response<bool>(false, ex.Message); // Return a response with the error message
            }
        }

    }
}
