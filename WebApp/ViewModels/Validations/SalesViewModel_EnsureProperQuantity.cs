using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.Validations
{
	public class SalesViewModel_EnsureProperQuantity : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var salesViewModel = validationContext.ObjectInstance as SalesViewModel;
			if (salesViewModel != null)
			{
				if(salesViewModel.QuantityToSell <= 0)
				{
					return new ValidationResult("The quantity to sell has to be greater than zero");
				}
			}
			return ValidationResult.Success;
		}
		

	}
}
