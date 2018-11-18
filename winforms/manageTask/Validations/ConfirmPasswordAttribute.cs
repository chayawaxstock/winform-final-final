﻿using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Validations
{
  public  class ConfirmPasswordAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            string password = (validationContext.ObjectInstance as User).Password;
            if (value.ToString().Equals(password))
                return null;
            return new ValidationResult("confirm password is not like password",new List<string>() { "ConfirmPassword" });
        }
    }
}
