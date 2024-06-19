using System.ComponentModel.DataAnnotations;


namespace DevExpressBlazorTest.Shared.Models.Forms;

public class CheckoutForm
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "We need the address to deliver the product.")]
    public string Address { get; set; } = "";
}
