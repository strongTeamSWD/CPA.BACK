using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.Models
{
    public class User
    {

        public long Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birth_date { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public User() {
        }

        public User(long id, string login, string name, string surname, DateTime birth_date, string email, string phone)
        {
            this.Id = id;
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.birth_date = birth_date;
            this.email = email;
            this.phone = phone;
        }
    }
}
