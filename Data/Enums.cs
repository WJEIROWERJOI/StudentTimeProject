﻿using System.ComponentModel.DataAnnotations;

public enum StudentGrade
{
    [Display(Name = "고1")]
    High1 = 4,
    [Display(Name = "고2")]
    High2 = 5,
    [Display(Name = "고3")]
    High3 = 6,
    [Display(Name = "중1")]
    Middle1 = 1,
    [Display(Name = "중2")]
    Middle2 = 2,
    [Display(Name = "중3")]
    Middle3 = 3,
    [Display(Name = "외")]
    Others = 0
}
