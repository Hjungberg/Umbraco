using System.ComponentModel.DataAnnotations;

namespace UmbracoCms.ViewModels;

public class CallbackFormViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [Display(Name = "Full Name")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Email is required")]
    [Display(Name = "Email Address")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Phone is required")]
    [Display(Name = "Phone Number")]
    public string Phone { get; set; } = null!;
    [Required(ErrorMessage = "Please select an option")]
    public string SelectedOption { get; set; } = null!;
}
