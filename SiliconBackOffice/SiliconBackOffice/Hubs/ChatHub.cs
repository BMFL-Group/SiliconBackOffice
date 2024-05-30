using Microsoft.AspNetCore.SignalR;
using Microsoft.JSInterop;

namespace SiliconBackOffice.Hubs;

public class ChatHub : Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }

    public async Task Typing(string userName)
    {
        await Clients.Others.SendAsync("UserTyping", userName);
    }

    public async Task SendMessageToAll(string fromUser, string message, DateTime dateTime)
    {
        await Clients.All.SendAsync("ReceiveMessage", fromUser, string.Empty, message, dateTime);
    }
    

}
