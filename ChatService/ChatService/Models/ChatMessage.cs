using System;
using ChatService.EventHandlers;

namespace ChatService.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public String User { get; set; }
        public String Message { get; set; }
        public int Room { get; set; }

        public event EventHandler<ChatEventArgs> MessageReceived;
        protected virtual void OnMessageReceived(ChatEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }
    }
}
