using Blog.Contracts.Requests;
using FluentValidation;

namespace Blog.Api.Validators
{
    public class CreatePostRequestValidator : AbstractValidator<CreatePostRequest>
    {
        public CreatePostRequestValidator()
        {
            RuleFor(i => i.BlogPost.Title)
                .NotEmpty();
            RuleFor(i => i.BlogPost.Description)
                .NotEmpty();
            RuleFor(i => i.BlogPost.Body)
                .NotEmpty();
        }
    }
}
