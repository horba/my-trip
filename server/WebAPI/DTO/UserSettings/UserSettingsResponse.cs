using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Entities.Models.Enums;

namespace WebAPI.DTO.UserSettings
{
    public class UserSettingsResponse
    {
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }

        public string[] Countries => Enum.GetNames(typeof(Country));
        public string[] Genders => Enum.GetNames(typeof(Gender));
        public string[] Languages => Enum.GetNames(typeof(Language));

        public UserSettingsResponse(User user)
        {
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Country = user.Country.ToString();
            Gender = user.Gender.ToString();
            Language = user.Language.ToString();
        }
    }
}
