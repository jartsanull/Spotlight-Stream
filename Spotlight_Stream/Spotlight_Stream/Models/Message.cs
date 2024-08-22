using System;
using System.ComponentModel.DataAnnotations;

namespace Spotlight_Stream.Models
{
    public class Message{

        [Key]
        private long Id;
        [Required]
        public string Sender { get; set; }
        public string Content { get; set; }

        public Message(){
        }

        public Message(string sender, string content){
            this.Sender = sender;
            this.Content = content;
        }
    }
}