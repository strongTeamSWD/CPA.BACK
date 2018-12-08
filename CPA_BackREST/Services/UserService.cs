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
        EncryptService encryptService;


        public UserService(RepositoryFactory repositoryFactory,EncryptService encryptService) {
            this.repositoryFactory = repositoryFactory;
            this.encryptService = encryptService;
            userRepository = repositoryFactory.GetRepository(typeof(Users)) as Repository<Users>;
            roleRepository = repositoryFactory.GetRepository(typeof(Roles)) as Repository<Roles>;
            
            userRepository.CreateTable();
        }

        void RecreateDB() {
            userRepository.CreateTable();
            roleRepository.CreateTable();
        }

        public Users GetUserByLoginPass(string login, string password) {
            password = encryptService.EncryptText(password);
            return userRepository.ReadOne("login=@Login and password=@Password", new { Login = login, Password = password });
        }

        public long RegisterUser(Users newUser){
            newUser.Password = encryptService.EncryptText(newUser.Password);
            return (long)userRepository.Add(newUser);
        }

        public bool UpdateUser(Users user) {
            return userRepository.Update(user);
        }
    }
}
