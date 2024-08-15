using System;

namespace Spotlight_Stream.Models
{
    public class User{

        private int Id;
        private string username {  get; set; }
        private string password { get; set; }
        private string email { get; set; }
    

    public User(){
    }

    public User(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }
}
}
