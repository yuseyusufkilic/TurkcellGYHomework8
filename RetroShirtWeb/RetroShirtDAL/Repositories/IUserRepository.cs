using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public interface IUserRepository
    {
        Task<int> CreateAccount(User user);
        void DeleteAccount(int id);
        User GetUser(string username,string password);
        bool IsUserExist(string username, string email);
        Task<IList<User>> GetAllUsers();
    }
}
