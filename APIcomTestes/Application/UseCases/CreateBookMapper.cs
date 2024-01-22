using AutoMapper;
using Domain.Entities;

namespace Application.UseCases
{
    public class CreateBookMapper : Profile
    {
        public CreateBookMapper()
        {
            CreateMap<CreateBookRequest, Book>();
            CreateMap<Book, CreateBookResponse>();
        }
    }
}