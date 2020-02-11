using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class UserExtension
    {
        public static DTO.User ToDTO(this Models.User u){
            return new DTO.User
            {
                Id = u.Id.ToString(),
                Email = u.Email,
                FullName = u.FullName,
                Gender = u.Gender
            };
        }

        public static Models.User ToDatabaseModel(this DTO.User u)
        {
            return new Models.User
            {
                Id = Guid.Parse(u.Id),
                Email = u.Email,
                FullName = u.FullName,
                Gender = u.Gender,

            };
        }
    }
}
