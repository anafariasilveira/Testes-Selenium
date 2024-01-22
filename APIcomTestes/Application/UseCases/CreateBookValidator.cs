using FluentValidation;

namespace Application.UseCases
{
    public class CreateBookValidator : AbstractValidator<CreateBookRequest>
    {
        public CreateBookValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255)
                .Must(FirstLetterBeInUpperCase)
                .WithMessage("Title is invalid: Title must contain a minimun of 5 characters and a maximum of 255, and the first letter should be in upper case");

            RuleFor(x => x.Author)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(30)
                .Must(FirstLetterBeInUpperCase)
                .WithMessage("Author is invalid: Author must conain a minimun of 3 characters and a maximum of 30, and the first letter should be in upper case");

            RuleFor(x => x.PublicationDate)
                .NotEmpty()
                .GreaterThan(new DateTime(1900, 1, 1))
                .LessThan(DateTime.Now)
                .WithMessage("PublicationDate is invalid: PublicationDate must be after 01/01/1900 and before the current date");
        }
        private bool FirstLetterBeInUpperCase(string title)
        {
            if (string.IsNullOrEmpty(title))
                return false;

            return char.IsUpper(title[0]);
        }
    }
}