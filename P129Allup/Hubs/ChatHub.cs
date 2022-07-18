using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using P129Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.Hubs
{
    public class ChatHub : Hub
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser appUser = _userManager.Users.FirstOrDefaultAsync(u => !u.IsAdmin && u.UserName == Context.User.Identity.Name).Result;

                if (appUser != null)
                {
                    appUser.ConnectionId = Context.ConnectionId;
                    appUser.ConnectedAt = null;

                    IdentityResult identityResult = _userManager.UpdateAsync(appUser).Result;

                    Clients.All.SendAsync("online", appUser.Id);
                }
            }

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser appUser = _userManager.Users.FirstOrDefaultAsync(u => !u.IsAdmin && u.UserName == Context.User.Identity.Name).Result;

                if (appUser != null)
                {
                    appUser.ConnectionId = null;
                    appUser.ConnectedAt = DateTime.UtcNow.AddHours(4);

                    IdentityResult identityResult = _userManager.UpdateAsync(appUser).Result;

                    Clients.All.SendAsync("ofline", appUser.Id);
                }
            }

            return base.OnDisconnectedAsync(exception);
        }

        public async Task Sender(string id,string message)
        {
            AppUser appUser = _userManager.FindByIdAsync(id).Result;

            await Clients.Client(appUser.ConnectionId).SendAsync("jsSender",id,message);
     
        }
    }
}
