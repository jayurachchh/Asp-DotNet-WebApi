/*using FluentValidation;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Properties.Validation
{
    public class Ragister :AbstractValidator<RagistrationModel>
    {
        public Ragister()
        {
            RuleFor(r=>r.UserName).NotEmpty().WithMessage("Username is requried");

            RuleFor(r=>r.Password).NotEmpty().MinimumLength(6).WithMessage("Password requried").Length(6,10);

            RuleFor(r=>r.PasswordConfirmed).NotEmpty().Equal(r=>r.Password).WithMessage("password requried").MinimumLength(6).Length(6,10);

            RuleFor(r => r.Email).EmailAddress().NotEmpty().WithMessage("Email Address requried");
        }
    }
}
*/