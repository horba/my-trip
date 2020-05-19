using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Entities.Models.Enums;

namespace WebAPI.DTO.UserSettings
{
    public class UserSettingsRequest
    {
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }

        public void ApplyToUser(User user)
        {
            user.Email = Email;
            user.FirstName = FirstName;
            user.LastName = LastName;

            user.Country = Enum.Parse<Country>(Country, true);
            user.Gender = Enum.Parse<Gender>(Gender, true);
            user.Language = Enum.Parse<Language>(Language, true);
        }
    }
}
