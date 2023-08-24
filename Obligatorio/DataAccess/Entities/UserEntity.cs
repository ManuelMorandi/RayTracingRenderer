using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class UserEntity
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Creation { get; set; }

        public static UserEntity FromDomain(User user)
        {
            return new UserEntity 
            {
                UserName = user.UserName,
                Password = user.Password,
                Creation = user.Creation,
            };
        }

        public static User ToDomain(UserEntity entity)
        {
            return new User 
            {
                UserName = entity.UserName,
                Password = entity.Password,
                Creation = entity.Creation
            };
        }
    }
}
