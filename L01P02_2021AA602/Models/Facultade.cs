using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021AA602.Models;

public partial class Facultade
{
    [Key]
    [Display(Name = "ID")]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Facultad")]
    [Required]
    public string? Facultad { get; set; }
}
