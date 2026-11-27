using System.ComponentModel.DataAnnotations;

namespace Lab9.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Product name")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    [Required]
    [Range(0, 1000000)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Required]
    [Range(0, 100000)]
    [Display(Name = "Stock quantity")]
    public int StockQuantity { get; set; }
}
