using RetroShirt.Business.Abstract;
using RetroShirtDAL.Repositories;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Concrete
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<int> CreateAccount(User user)
        {           
            return await userRepository.CreateAccount(user);
        }

        public void DeleteAccount(int id)
        {
            userRepository.DeleteAccount(id);
        }

        public async Task<IList<User>> GetUserRoles()
        {
            return await userRepository.GetAllUsers();
        }

        public bool UserIsExist(string username, string email)
        {
            return userRepository.IsUserExist(username, email);
        }

        public User GetUser(string username, string password)
        {
            var user=userRepository.GetUser(username, password);
            return user;
        }
    }
}
