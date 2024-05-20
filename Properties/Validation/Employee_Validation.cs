using FluentValidation;
using Project_Management_Admin_Panel.Models;
using System;

namespace Project_Management_Admin_Panel.Properties.Validation
{
    public class Employee_Validation :AbstractValidator<Employee>
    {
        public Employee_Validation()
        {
     /*       RuleFor(e => e.EmpID).NotEmpty().InclusiveBetween(1, 20).ExclusiveBetween(1, 30).
                LessThan(20).GreaterThan(15).GreaterThanOrEqualTo(15).LessThanOrEqualTo(20).
                WithMessage("id is requried");

            RuleFor(e => e.EmpName).NotEmpty().WithMessage("Employee requried").NotNull().
                WithMessage("Employee Notnull");

            RuleFor(e => e.EmpEmail).NotEqual("abc@gmail.com").WithMessage("this email is not allowed").
                Matches("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n").WithMessage("email is valid").
                EmailAddress().WithMessage("enter valid email");

            RuleFor(e => e.EmpCode).NotEmpty().
                DependentRules(() =>
            {
                RuleFor(e => e.EmpName).NotEmpty().WithMessage("cannot be empty");
            });*/

/*            RuleFor(e => e.EmpDateOfBirth).NotEmpty().GreaterThan(DateTime.Now).WithMessage("select future date").
                InclusiveBetween(DateTime.Today, DateTime.Today.AddMonths(1)).WithMessage("Event must be next month").
                LessThan(DateTime.Now.AddDays(30)).WithMessage("event only withhin 30 days");
            RuleFor(e => e.EmpDateOfBirth).Must((date) => date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday).
                WithMessage("Event not organized saturday or sunday");*/

        }
    }
}
