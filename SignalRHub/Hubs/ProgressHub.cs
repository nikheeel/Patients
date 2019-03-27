using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRHub.Hubs
{
    public class ProgressHub : Hub
    {
        public void Progress(string msg)
        {
            Clients.All.SendAsync("Update", msg);
        }
    }
}
