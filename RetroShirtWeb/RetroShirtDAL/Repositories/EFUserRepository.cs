using Microsoft.EntityFrameworkCore;
using RetroShirtDAL.Data;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public class EFUserRepository:IUserRepository
    {
        private RetroShirtDBContext dBContext;

        public EFUserRepository(RetroShirtDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<int> CreateAccount(User user)
        {
            await dBContext.Users.AddAsync(user);
            await dBContext.SaveChangesAsync();

            return user.Id;
        }

        public void DeleteAccount(int id)
        {
            var account=dBContext.Users.FirstOrDefault(x => x.Id == id);
            dBContext.Users.Remove(account);
            dBContext.SaveChanges();
        }

        public async Task<IList<User>> GetAllUsers()
        {
            return await dBContext.Users.ToListAsync();
        }

        public User GetUser(string username, string password)
        {
            var user=dBContext.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            return user;
        }
        
        public bool IsUserExist(string username, string email)
        {
            return dBContext.Users.Any(x=>x.Username==username && x.Email==email);
        }
    }
}
