using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAPI.Models
{
	public class Employee
	{
		[Key]
		[Required]
		public int EmployeeId { get; set; }
		[MaxLength(150,ErrorMessage ="Max Lenght 150 Characters !")]
		public string? EmployeeName { get; set; }
		[MaxLength(50,ErrorMessage ="Max Lenght 50 Characters !")]
		[MinLength(10)]
		public string? EmployeeEmail { get; set; }
		[Range(1,999999)]
		[Column("PhoneNumber")]
		public int? EmployeeNumber { get; set; }
	}
}
