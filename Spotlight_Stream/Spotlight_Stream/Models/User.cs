using System;
using System.ComponentModel.DataAnnotations;

namespace Spotlight_Stream.Models{
    public class User{

        [Key]
        public long Id;

        public string Username {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    

    public User(){
    }

    public User(string username, string password, string email){
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
    }
}
