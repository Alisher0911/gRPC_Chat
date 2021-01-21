using System;
namespace ChatService.EventHandlers
{
    public class ChatEventArgs
    {
        public DateTime ReceivedDate { get; set; }
        public string SenderName { get; set; }

        public ChatEventArgs(DateTime receivedDate, string senderName)
        {
            ReceivedDate = receivedDate;
            SenderName = senderName;
        }
    }
}
