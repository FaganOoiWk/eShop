namespace eShop.Identity.API.Models;

public class UserProfile
{
    [Key]
    public string Id { get; set; }

    [Required]
    public string UserId { get; set; }

    public ApplicationUser User { get; set; }

    public string ShopName { get; set; }

    public string ShopUrl { get; set; }

    public string ShopDescription { get; set; }
}
