using System;
using System.Collections.Generic;

namespace GraduateProject.Models;

public class Profile
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }
}
