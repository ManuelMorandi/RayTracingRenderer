using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDbUserRepository
    {
        void AddUser(User user);

        User GetUser(string name);

        bool ExistsUser(string name);
    }
}
