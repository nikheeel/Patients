using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRHub.Hubs
{
    public class UpdateHub : Hub
    {
        public Dictionary<String, string> Connections { get; set; }

        public UpdateHub()
        {
            Connections = new Dictionary<string, string>();
        }

        public void Update(string clientName)
        {
            Clients.All.SendAsync("Said", "Hi");

            Clients.Group(clientName).SendAsync("Info", "Hi");
        }

        public void Register(string clientName)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, clientName);
            Connections.Add(Context.ConnectionId, clientName);
        }

        public override Task OnConnectedAsync()
        {
            var connectId = Context.ConnectionId;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
