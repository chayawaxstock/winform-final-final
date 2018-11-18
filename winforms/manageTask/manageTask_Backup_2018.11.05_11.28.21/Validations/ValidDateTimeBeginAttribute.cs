﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Validations
{
    public class ValidDateTimeBeginAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            if (DateTime.Parse(value.ToString()) >= DateTime.Now)
                return null;
            return new ValidationResult("date begin project less than today");
        }

    }
}
