using Microsoft.AspNetCore.SignalR;

namespace EXE201_HOMIE.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceviceMessage", $"{Context.ConnectionId} has join");
        }
    }
}
