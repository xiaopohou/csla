﻿using System;

namespace System.ComponentModel.DataAnnotations
{
  /// <summary>
  /// Specifies that a data field value is required.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class RequiredAttribute : ValidationAttribute
  {
    /// <summary>
    /// Creates an instance of the attribute.
    /// </summary>
    public RequiredAttribute()
    {
      ErrorMessage = "Field is required.";
    }

    /// <summary>
    /// Validates the specified value with respect to
    /// the current validation attribute.
    /// </summary>
    /// <param name="value">Value of the object to validate.</param>
    /// <param name="validationContext">The context information about the validation operation.</param>
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if (string.IsNullOrEmpty(value.ToString()))
        return new ValidationResult(this.ErrorMessage);
      else
        return null;
    }
  }
}
