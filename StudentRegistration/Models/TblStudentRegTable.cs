using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentRegistration.Models;

public partial class TblStudentRegTable
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Please select a valid academic year.")]
    [Range(1, 1, ErrorMessage = "Please select a valid academic year.")]
    public int AcademicYear { get; set; }

    [Required(ErrorMessage = "Please select School UDISE code.")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "Please enter a valid 11-digit UDISE code.")]
    public string SchoolUdisecode { get; set; } = null!;


    [Required(ErrorMessage = "School Name is required.")]
    [StringLength(50, ErrorMessage = "School Name cannot be longer than 50 characters.")]
    public string SchoolName { get; set; } = null!;

    [Required(ErrorMessage = "School Name in Hindi is required.")]
    [StringLength(50, ErrorMessage = "School Name in Hindi cannot be longer than 50 characters.")]
    public string SchoolNameHindi { get; set; } = null!;

    [Required(ErrorMessage = "Year of Establishment is required.")]
    public DateOnly YearOfEstablishment { get; set; }

    [Required(ErrorMessage = "Board Type Code is required.")]
    [Range(1, 10, ErrorMessage = "Board Type Code must be between 1 and 10.")]
    public byte BoardTypeCode { get; set; }

    [Required(ErrorMessage = "Board Code is required.")]
    public bool BoardCode { get; set; }

    [Required(ErrorMessage = "School Type Code is required.")]
    [StringLength(10, ErrorMessage = "School Type Code cannot be longer than 10 characters.")]
    public string SchoolTypeCode { get; set; } = null!;
}
