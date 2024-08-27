using System.ComponentModel.DataAnnotations;

namespace Solvefy_Assessment.Models;
public class Product
{
    public int Id { get; set; }
    [Required][StringLength(100)] 
    public string Name { get; set; } = default!;
    [Required] public decimal Price { get; set; }
    [StringLength(500)] 
    public string Description { get; set; }= default!;  
    [Required] public int Stock { get; set; }
}

