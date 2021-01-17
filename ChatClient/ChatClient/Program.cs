using System;
using System.Threading.Tasks;
using ChatService;
using Grpc.Core;
using Grpc.Net.Client;

namespace ChatClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter your name :");
            string username = Console.ReadLine();

            var channel = GrpcChannel.ForAddress("http://localhost:5001");
            var client = new ChatRoomService.ChatRoomServiceClient(channel);

            using (var chat = client.Join())
            {
                _ = Task.Run(async () =>
                {
                    while (await chat.ResponseStream.MoveNext())
                    {
                        var response = chat.ResponseStream.Current;
                        Console.WriteLine($"{response.User}: {response.Text}");
                    }
                });

                await chat.RequestStream.WriteAsync(new Message { User = username, Text = $"{username} has joined!" });

                string line;
                while((line = Console.ReadLine()) != null)
                {
                    if (line.ToUpper() == "EXIT") break;
                    await chat.RequestStream.WriteAsync(new Message { User = username, Text = line });
                }

                await chat.RequestStream.CompleteAsync();
            }

            Console.WriteLine("Disconnected");
            await channel.ShutdownAsync();
        }
    }
}
