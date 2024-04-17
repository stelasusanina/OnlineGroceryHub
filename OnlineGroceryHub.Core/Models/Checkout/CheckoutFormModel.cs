using System.ComponentModel.DataAnnotations;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.CheckoutFormConsts;

public class CheckoutFormModel
{
    public int OrderId { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
        ErrorMessage = "{0} must be between {2} and {1} characters.")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength,
        ErrorMessage = "{0} must be between {2} and {1} characters.")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(StreetAddressMaxLength, MinimumLength = StreetAddressMinLength,
        ErrorMessage = "{0} must be between {2} and {1} characters.")]
    public string StreetAddress { get; set; } = null!;

    public string? AdditionalInfo { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(CityMaxLength, MinimumLength = CityMinLength,
        ErrorMessage = "{0} must be between {2} and {1} characters.")]
    public string City { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(PostCodeMaxLength, MinimumLength = PostCodeMinLength,
        ErrorMessage = "{0} must be exactly {1} characters.")]
    public string Postcode { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(PhoneCodeMaxLength, MinimumLength = PhoneCodeMinLength,
        ErrorMessage = "{0} must be exactly {1} characters.")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(EmailMaxLength, MinimumLength = EmailMinLength,
        ErrorMessage = "{0} must be between {2} and {1} characters.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = null!;
}
