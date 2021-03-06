﻿using System.ComponentModel.DataAnnotations;
using Entities.Models.Enums;
using WebAPI.Validators;

namespace WebAPI.DTO.UserSettings
{
  public class UserSettingsDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ValidEnum]
        public Gender Gender { get; set; }
        public int? CountryId { get; set; }
        public int? LanguageId { get; set; }
        public string AvatarFileName { get; set; }
  }
}
