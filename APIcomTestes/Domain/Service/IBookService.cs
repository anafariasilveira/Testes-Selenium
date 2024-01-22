using Domain.Entities;

namespace Domain.Service
{
    public interface IBookService
    {
        public bool CreateBook(Book book);
    }
}
