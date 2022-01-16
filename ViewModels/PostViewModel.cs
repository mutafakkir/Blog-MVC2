using System.ComponentModel.DataAnnotations;

namespace blog2.ViewModels;

public class PostViewModel
{ 
    public Guid? Id { get; set; } = default(Guid);
    
    [Required]
    [MaxLength(15)]
    public string Title { get; set; }
    
    [Required]
    public string Content { get; set; }
    public bool Edited { get; set; }
    public ulong Claps { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string BannerImageUrl { get; set; }
}