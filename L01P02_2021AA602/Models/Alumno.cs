using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021AA602.Models;

public partial class Alumno
{
    [Key]
    public int Id { get; set; }

    [Display(Name ="Codigo")]
    [Required]
    public string? Codigo { get; set; }

    [Display(Name = "Nombre")]
    [Required]
    public string? Nombre { get; set; }

    [Display(Name = "Apellidos")]
    [Required]
    public string? Apellidos { get; set; }

    [Display(Name = "DUI")]
    [Required]
    public int? Dui { get; set; }

    [Display(Name = "Estado")]
    [Required]
    public int? Estado { get; set; }
}
