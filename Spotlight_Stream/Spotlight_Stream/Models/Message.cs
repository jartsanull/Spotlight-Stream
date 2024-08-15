using System;
using System.ComponentModel.DataAnnotations;

namespace Spotlight_Stream.Models
{
    public class Message{

        [Key]
        private int Id;

        private string sender { get; set; }
        private string content { get; set; }

        public Message()
        {
        }

        public Message(string sender, string content){
            this.sender = sender;
            this.content = content;
        }
    }
}