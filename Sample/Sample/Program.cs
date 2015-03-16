using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{

    [Table]

    class _User
    {
        [Column(Name = "username")]
        public string username;
        [Column(Name = "password")]
        public string password;
        [Column(Name = "firstname")]
        public string firstname;
        [Column(Name = "lastname")]
        public string lastname;
        [Column(Name = "email")]
        public string email;
        [Column(Name = "address")]
        public string address;
        [Column(Name = "phonenumber")]
        public string phonenumber;
        [Column(Name = "verified")]
        public bool verified;
        [Column(Name = "admin")]
        public bool admin;
        [Column(Name = "ownedTeams")]
        public string ownedTeams;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
