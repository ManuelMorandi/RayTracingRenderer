using Domain;
using DataAccess.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using System.Xml.Linq;

namespace DataAccess
{
    public class RepoUser : IDbUserRepository
    {
        public RepoUser() { }

        public void AddUser(User user)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var entity = UserEntity.FromDomain(user);
                    dbContext.UserEntities.Add(entity);
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw new DataBaseException("Nombre de usuario ya registrado");
            }
        }
        public User GetUser(string username)
        {
            using (var dbContext = new DBContext())
            {
                var query = from u in dbContext.UserEntities
                            where u.UserName == username
                            select u;
                var userEntity = query.FirstOrDefault<UserEntity>();
                if (UserIsEmpty(userEntity))
                {
                    var user = UserEntity.ToDomain(userEntity);
                    return user;
                }
                else
                {
                    throw new DataBaseException("Nombre de usuario o contraseña incorrectos");
                }
            }
        }
        public bool ExistsUser(string username)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var query = from u in dbContext.UserEntities
                                where u.UserName.Equals(username)
                                select u;
                    var userEntity = query.FirstOrDefault<UserEntity>();
                    if (UserIsEmpty(userEntity))
                    {
                        var user = UserEntity.ToDomain(userEntity);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                throw new DataBaseException(e.Message);
            }
        }

        private static bool UserIsEmpty(UserEntity userEntity)
        {
            return userEntity != null;
        }
    }
}
