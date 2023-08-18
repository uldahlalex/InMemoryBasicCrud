using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace service;

public class Book
{
    [Range(0, int.MaxValue)]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Author { get; set; }
}