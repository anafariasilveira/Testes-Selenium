using Persistence.Context;
using Domain.Entities;
using Domain.Interfaces;

namespace Persistence.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
