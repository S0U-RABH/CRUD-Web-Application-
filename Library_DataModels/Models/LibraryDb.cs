using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_DataModels.Models;

public partial class LibraryDb
{
    public int BookId { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    public string? Author { get; set; }

    [Required(ErrorMessage = "ISBN is required")]
    [RegularExpression(@"^(?:ISBN(?:-13)?:?\s)?(?=[0-9]{13}$|(?=(?:[0-9]+[-\s]){4})[-\s0-9]{17}$|97[89][-\s]?[0-9]{9}[-\s]?[0-9X]$)[0-9]{1,5}[-\s]?[0-9]+[-\s]?[0-9]+[-\s]?[0-9X]$",
           ErrorMessage = "Invalid ISBN format")]
    public string? Isbn { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Description should not exceed 500 characters")]
    public string? Discription { get; set; }

    public byte[]? PhotoPath { get; set; }
}
