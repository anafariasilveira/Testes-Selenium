using Domain.Service;
using Domain.Entities;
using NSubstitute;
using FluentAssertions;

namespace Test
{
    public class BookTest
    {
        private readonly IBookService _mockBookService;
        private BookService _sut;

        public BookTest()
        {
            _mockBookService = Substitute.For<IBookService>();
            _sut = new(_mockBookService);
        }

        [Fact]
        public void CreateBook_BookCreateSuccessfully()
        {
            Book book = new()
            {
                Title = "Test",
                Author = "Test",
                PublicationDate = new DateTime(2008, 08, 01)
            };

            _mockBookService.CreateBook(book).Returns(true);

            bool result = _sut.CreateBook(book);

            result.Should().BeTrue();
        }
        [Fact]
        public void CreateBook_TitleIsNull_DoesntCreateBook()
        {
            Book book = new()
            {
                Title = null,
                Author = "Test",
                PublicationDate = new DateTime(2008, 08, 01)
            };

            _mockBookService.CreateBook(book).Returns(false);

            bool result = _sut.CreateBook(book);

            Assert.False(result);
        }
    }
}
