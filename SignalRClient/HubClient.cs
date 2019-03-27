using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

namespace SignalRClient
{
    public class HubClient
    {
        public HubConnection _connection { get; set; }

        public HubClient()
        {
            _connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:58085/updatedemo")
                .ConfigureLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddConsole();
                    builder.AddDebug();
                })
                .Build();

            _connection.Closed += async (error) =>
            {
                Debugger.Launch();
                await Task.Delay(5000);
                await _connection.StartAsync();
            };

            _connection.On<string>("Said", Said);

            _connection.StartAsync().Wait();

            _connection.InvokeAsync("Register", "Backend").Wait();

            _connection.InvokeAsync("Update", "UI").Wait();

            _connection.On<string>("Info", Info);

        }




        private void Said(string msg)
        {
            var ff = msg;
        }

        private void Info(string msg)
        {
            var ff = msg;
        }

    }
}
