using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonCode8.Domain.Entities;

public class DatModel
{
    [Required]
    public int Math_test { get; set; }
    [Required]
    public int Programming_Concepts_test { get; set; }
    [Required]
    public int Communication_skills_test { get; set; }
    [Required]
    public int Working_per_day { get; set; }
    [Required]
    public int Logic_test { get; set; }
    [Required]
    public int Hackathons { get; set; }
    [Required]
    public int Gender { get; set; }
    [Required]
    public int Introvert { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public int Public_speaker { get; set; }
    [Required]
    public int Realtionship { get; set; }
}
