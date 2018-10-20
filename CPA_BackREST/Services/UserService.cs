using CPA_BackREST.Models;
using CPA_BackREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.Services
{

    public class UserService
    {
        UserRepository userRepository;

        public UserService(UserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public User GetUserByLoginPass(string login,string password) {
            return userRepository.GetByLoginPassword(login,password);
        }

        public long RegisterUser(User newUser)
        {
            if(newUser.login != null && newUser.password != null && newUser.name != null
                && newUser.surname != null && newUser.email != null)
            {
                return userRepository.insertUser(newUser);
            }

            return -1;
        }
    }
}
