using AutoMapper;
using Domain.Interfaces;
using MediatR;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class CreateBookHandler : IRequestHandler<CreateBookRequest, CreateBookResponse>
    {
        private readonly IUnitOfWork _unitOfWhork;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public CreateBookHandler(IUnitOfWork unitOfWork, IMapper mapper, IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _unitOfWhork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CreateBookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);

            _bookRepository.Create(book);
            
            await _unitOfWhork.Commit(cancellationToken);

            return _mapper.Map<CreateBookResponse>(book);
        }
    }
}