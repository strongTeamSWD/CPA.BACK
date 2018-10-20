using CPA_BackREST.DB;
using CPA_BackREST.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private DBUtil _dbUtil;

        private const string COL_ID = "id";
        private const string COL_NAME = "name";
        private const string COL_SURNAME = "surname";
        private const string COL_LOGIN = "login";
        private const string COL_BIRTH = "birth_date";
        private const string COL_EMAIL = "email";
        private const string COL_ACTIVE = "is_active";
        private const string COL_PSW = "password";
        private const string COL_PHN = "phoneNumber";

        private MySql.Data.MySqlClient.MySqlCommand cmd;
        private const string INSERT_SQL = "INSERT INTO  users (birth_date,email,is_active,login,name,password,surname)" +
            " VALUES (@birth_date ,@email ,1,@login ,@name ,@password ,@surname)";
        private const string DELETE_SQL = "Delete from Users Where id = @id";
        private const string GET_SQL = "Select * from Users Where id = @id";
    
        private const string GET_BY_LOG_PAS_SQL = "Select * from Users Where login = @login and password = @password and is_active = 1";
        //  private const string UPDATE_SQL = "Update Users()";


        public UserRepository(DBUtil dbUtil)
        {
            _dbUtil = dbUtil;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public User GetByLoginPassword(string login,string password) {
            User retUser = null;
            
            password = _dbUtil.ecryptPsw(password);
            cmd = _dbUtil.CreateCmd(GET_BY_LOG_PAS_SQL);
            cmd.Parameters.AddWithValue("@"+COL_LOGIN,login);
            cmd.Parameters.AddWithValue("@"+COL_PSW,password);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr != null && rdr.Read()) {
                retUser = new User(
                    rdr[COL_ID] as long? ?? default (long),
                    rdr[COL_LOGIN] as string,
                    rdr[COL_NAME] as string,
                    rdr[COL_SURNAME] as string,
                    rdr[COL_BIRTH] as DateTime ? ??default(DateTime),
                    rdr[COL_EMAIL] as string,
                    rdr[COL_PHN] as string);
            }
            rdr.Close();

            return retUser; 
        }

        public User Get(long id)
        {
            throw new NotImplementedException();
        }

        public long insertUser(User user)
        {
            try
            {
                user.password = _dbUtil.ecryptPsw(user.password);
                cmd = _dbUtil.CreateCmd(INSERT_SQL);
                cmd.Parameters.AddWithValue("@" + COL_LOGIN, user.login);
                cmd.Parameters.AddWithValue("@" + COL_PSW, user.password);
                cmd.Parameters.AddWithValue("@" + COL_NAME, user.name);
                cmd.Parameters.AddWithValue("@" + COL_SURNAME, user.surname);
                cmd.Parameters.AddWithValue("@" + COL_EMAIL, user.email);
                cmd.Parameters.AddWithValue("@" + COL_BIRTH, user.birth_date);
                cmd.ExecuteNonQuery();
                long retId = cmd.LastInsertedId;
                return retId;
            }
            catch (Exception e) {
                cmd.Cancel();

                Console.WriteLine(e);
                return -1;
            }
        }

        public long Save(User newObj)
        {
            throw new NotImplementedException();
        }

        public User Update(User newObj)
        {
            throw new NotImplementedException();
        }
    }
}
