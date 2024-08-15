using System;
using System.ComponentModel.DataAnnotations;

namespace Spotlight_Stream.Models
{
    public class Message{

        [Key]
        private long Id;

        private string Sender { get; set; }
        private string Content { get; set; }

        public Message(){
        }

        public Message(string sender, string content){
            this.Sender = sender;
            this.Content = content;
        }
    }
}