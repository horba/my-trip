using System;
using System.ComponentModel.DataAnnotations;
using Entities.Models;
using Entities.Models.Enums;
using WebAPI.Validators;

namespace WebAPI.DTO.UserSettings
{
    public class UserSettingsRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Enumable(typeof(Country))]
        public string Country { get; set; }

        [Enumable(typeof(Language))]
        public string Language { get; set; }
        
        [Enumable(typeof(Gender))]
        public string Gender { get; set; }

        public void ApplyToUser(User user)
        {
            user.Email = Email;
            user.FirstName = FirstName;
            user.LastName = LastName;

            user.Country = Enum.Parse<Country>(Country, true);
            user.Language = Enum.Parse<Language>(Language, true);
            user.Gender = Enum.Parse<Gender>(Gender, true);
        }
    }
}
