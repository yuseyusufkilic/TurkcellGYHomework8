using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Abstract
{
    public interface IUserService
    {
        Task<int> CreateAccount(User user);
        void DeleteAccount(int id);
        bool UserIsExist(string username,string email);
        User GetUser(string username, string password);
        Task<IList<User>> GetUserRoles();
    }
}
