using MediatR;

namespace Application.UseCases
{
    public sealed record CreateBookRequest(string Title, string Author, DateTime PublicationDate) : IRequest<CreateBookResponse>
    {
    }
}
