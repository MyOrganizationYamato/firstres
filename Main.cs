using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTANetworkAPI;

namespace firstres
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            var playerCount = ContextFactory.Instance.Accounts.Count();
            NAPI.Util.ConsoleOutput("[DataBase]Conturi create: " + playerCount);
			muie cu cacat;
        }

    }
}