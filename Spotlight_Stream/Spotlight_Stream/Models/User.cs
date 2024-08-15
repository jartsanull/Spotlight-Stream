using System;
using System.ComponentModel.DataAnnotations;

namespace Spotlight_Stream.Models
{
    public class User{

        [Key]
        private int Id;

        private string Username {  get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
    

    public User(){
    }

    public User(string username, string password, string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
}
}
