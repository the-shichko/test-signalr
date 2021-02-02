using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace TestSignalR.Hubs
{
    public class DrawHub : Hub
    {
        public Task Draw(int prevX, int prevY, int currentX, int currentY)
        {
            return Clients.All
                .SendAsync("DrawLine", prevX, prevY, currentX, currentY);
        }
    }
}