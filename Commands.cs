using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTANetworkAPI;

namespace firstres
{
    public class Commands : Script
    {
        [Command("register")]
        public void AccountCmdRegister(Client player, string displayname , string username, string password)
        {

            RegisterAccount(player, displayname,username, password);
            NAPI.Chat.SendChatMessageToPlayer(player, "~g~Registration successful!");

        }
        [Command("login")]
        public void LoginTo(Client client, string username, string password)
        {

            Account loginAccount = ContextFactory.Instance.Accounts.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));

            if (loginAccount != null)
            {
                client.SendChatMessage("~r~Logged in succesfull");
            }
            else
            {
                client.SendChatMessage("~r~Account doesn't exist");
            }

        }
        [Command("getdata")]
        public void GetDataaa(Client client, int id)
        {

            Account loginAccount = ContextFactory.Instance.Accounts.FirstOrDefault(u => u.Id.Equals(id));

            client.SendChatMessage(loginAccount.Username);//asd

        }
        [Command("getdimension")]
        public void GetDim(Client client)
        {

            client.SendChatMessage(client.Dimension.ToString());

        }

        [Command("mesajlog")]
        public void Mesaje(Client client, string mesaj)
        {
            Staff_Log_Update(client, mesaj);
            client.SendChatMessage("~g~Staff log updatat!");
        }
        public static void Staff_Log_Update(Client client, string mesaj)
        {

            // create a new Account object
            var mesaje = new Staff_log
            {
                NumePlayer = client.Name,
                Mesaj = mesaj
            };

            // Add this account data to the current context
            ContextFactory.Instance.Staff_logs.Add(mesaje);

            // And finally insert the data into the database
            ContextFactory.Instance.SaveChanges();

        }

        public static void RegisterAccount(Client client, string displayname , string username, string password)
        {

            // create a new Account object
            var account = new Account
            {
                Username = username,
                Displayname = displayname,
                Password = password
            };

            // Add this account data to the current context
            ContextFactory.Instance.Accounts.Add(account);

            // And finally insert the data into the database
            ContextFactory.Instance.SaveChanges();

        }


    }
}