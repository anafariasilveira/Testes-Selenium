using Domain.Entities;

namespace Domain.Service
{
    public class BookService
    {
        private readonly IBookService _bookService;

        public BookService(IBookService bookService)
        {
            _bookService = bookService;
        }
        public bool CreateBook(Book book)
        {
            if (_bookService.CreateBook(book))
            {
                return true;
            }
                return false;
        }
       
    }
}
