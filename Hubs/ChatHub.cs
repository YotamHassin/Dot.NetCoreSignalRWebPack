using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRWebPack.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(string username, string message, string room)
				//public async Task NewMessage(string username, string message)
        {
            await Clients.All.SendAsync("MessageReceived", username, message, room);
						//await Clients[room].SendAsync("MessageReceived", username, message, room);
        }

				/* public async Task ChangeRoom(string username, string roomName)
        {
            await Clients.("MessageReceived", username, message);
        } */
    }
}
