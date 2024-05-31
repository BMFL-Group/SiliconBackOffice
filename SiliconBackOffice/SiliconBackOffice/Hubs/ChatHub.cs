using Microsoft.AspNetCore.SignalR;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SiliconBackOffice.Client.Models;
using System.Text;

namespace SiliconBackOffice.Hubs;

public class ChatHub : Hub
{
    public Task BroadcastMessage(string name, string message) =>
     Clients.All.SendAsync("broadcastMessage", name, message);

    public Task Echo(string name, string message) =>
        Clients.Client(Context.ConnectionId)
                .SendAsync("echo", name, $"{message} (echo from server)");




    //public override Task OnConnectedAsync()
    //{
    //    return base.OnConnectedAsync();
    //}

    //public override Task OnDisconnectedAsync(Exception? exception)
    //{
    //    return base.OnDisconnectedAsync(exception);
    //}

    //public async Task Typing(string userName)
    //{
    //    await Clients.Others.SendAsync("UserTyping", userName);
    //}

    //public async Task SendMessageToAll(string fromUser, string message, DateTime dateTime)
    //{
    //    //var json = JsonConvert.SerializeObject(new ChatMessage() { UserName = fromUser, Message = message, Created = dateTime });
    //    //var content = new StringContent(json, Encoding.UTF8, "application/json");

    //    //var result = await _httpClient.PostAsync($"{_configuration.GetConnectionString("LocalSignalRMessage")}", content);
    //    //if (result.IsSuccessStatusCode)
    //    //{
    //    //    string bla = "";
    //    //}
    //    await Clients.All.SendAsync("ReceiveMessage", fromUser, string.Empty, message, dateTime);
    //}


}
