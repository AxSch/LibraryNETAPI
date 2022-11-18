using System.ComponentModel.DataAnnotations;

namespace test_api.Models;

public class Book
{
    [Key]
    [Required]
    [Display(Name = "author")]
    public string Author { get; set; }
    
    [Required]
    [Display(Name = "title")]
    public string Title { get; set; }
    
    [Required]
    [Display(Name = "dateOfPublication")]
    public double? DateOfPublication { get; set; }
    
}