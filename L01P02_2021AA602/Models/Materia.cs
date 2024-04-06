using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021AA602.Models;

public partial class Materia
{
    [Key]
    [Display(Name = "ID")]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Materia")]
    [Required]
    public string? Materia1 { get; set; }

    [Display(Name = "Unidades Valorativas")]
    [Required]
    public int? UnidadesValorativas { get; set; }

    [Display(Name = "Estado")]
    [Required]
    public string? Estado { get; set; }
}
