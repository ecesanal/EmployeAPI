using deneme1.Models;
using FluentValidation;

namespace deneme1.Validation
{
	public class EmployeeValidator : AbstractValidator<Employee>
	{
		public EmployeeValidator()
		{
			RuleFor(x => x.EmployeeName).NotNull().WithMessage("Not Null Email Adress");
			RuleFor(x => x.EmployeeName).NotNull().NotEmpty().WithMessage("Please Not Null and Empty Emapoyee Name");
			RuleFor(x => x.EmployeeName).MaximumLength(100).WithMessage("You can write a max of 100 characters");


			RuleFor(x => x.EmployeeEmail).NotNull().NotEmpty().WithMessage("Please Not Null and Empty Emapoyee Email");
			RuleFor(x => x.EmployeeEmail).EmailAddress().WithMessage("Please write a correct e-mail adress");

            RuleFor(x => x.EmployeeNumber).NotNull().NotEmpty().WithMessage("Please Not Null and Empty Emapoyee Number");

        }
    }
}
