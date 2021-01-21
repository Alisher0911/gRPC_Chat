using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatService.Data;
using ChatService.EventHandlers;
using ChatService.Models;
using Grpc.Core;

namespace ChatService
{
    public class ChatRoom
    {
        private readonly DataContext _context;

        public ChatRoom(DataContext context)
        {
            _context = context;
        }

        private readonly ConcurrentDictionary<string, IServerStreamWriter<Message>> users = new ConcurrentDictionary<string, IServerStreamWriter<Message>>();

        public void Join(string name, IServerStreamWriter<Message> response) => users.TryAdd(name, response);
        public void Remove(string name) => users.TryRemove(name, out _);

        public async Task BroadcastMessageAsync(Message message) => await BroadcastMessage(message);
        private async Task BroadcastMessage(Message message)
        {
            foreach (var user in users.Where(x => x.Key != message.User))
            {
                var msg = new ChatMessage();
                msg.MessageReceived += msg_MessageReceived;

                var item = await SendMessageToSubscriber(user, message);
                if (item != null)
                {
                    Remove(item?.Key);
                }
            }
        }

        public void msg_MessageReceived(object sencer, ChatEventArgs e)
        {
            Console.WriteLine($"{e.SenderName} sent message at {e.ReceivedDate}.");
        }


        private async Task<KeyValuePair<string, IServerStreamWriter<Message>>?> SendMessageToSubscriber(KeyValuePair<string, IServerStreamWriter<Message>> user, Message message)
        {
            try
            {
                await user.Value.WriteAsync(message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;
            }
        }

        /*public async Task Send(Message message)
        {
            var msg = new ChatMessage
            {
                User = message.User,
                Message = message.Text,
                Room = message.Room
            };

            await _context.ChatMessages.AddAsync(msg);
            await _context.SaveChangesAsync();
        }*/
    }
}
