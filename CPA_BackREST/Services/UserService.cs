using CPA_BackREST.DB;
using CPA_BackREST.Models;
using CPA_BackREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Services
{

    public class UserService
    {
        RepositoryFactory repositoryFactory;

        Repository<Users> userRepository;
        Repository<Roles> roleRepository;
        
        public UserService(RepositoryFactory repositoryFactory) {
            this.repositoryFactory = repositoryFactory;

            userRepository = repositoryFactory.GetRepository(typeof(Users)) as Repository<Users>;
            roleRepository = repositoryFactory.GetRepository(typeof(Roles)) as Repository<Roles>; ;
        }

        void RecreateDB() {
            userRepository.CreateTable();
            roleRepository.CreateTable();
        }

        public Users GetUserByLoginPass(string login, string password) {
            return userRepository.ReadOne("login=@Login and password=@Password", new { Login = login, Password = password });
        }

        public long RegisterUser(Users newUser){
            return (long)userRepository.Add(newUser);
        }

        public bool UpdateUser(Users user) {
            return userRepository.Update(user);
        }
    }
}
