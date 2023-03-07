using Microsoft.AspNetCore.Mvc;
using RunningApp.Models;

namespace RunningApp.Repository
{
    public class UserRepository
    {

        private RunningDbContext _dbContext;
        public UserRepository()
        {
            _dbContext = new RunningDbContext();
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users;
        }

        public User? GetUser(int id)
        {
            var getUser = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            return getUser;
        }

        public User CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User? DeleteUser(int id)
        {
            var deleteUser = _dbContext.Users.FirstOrDefault(y => y.Id == id);

            if (deleteUser == null)
            {
                return deleteUser;
            }
            _dbContext.Users.Remove(deleteUser);
            _dbContext.SaveChanges();

            return deleteUser;
        }
    }
}
